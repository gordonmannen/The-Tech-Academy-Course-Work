// Making Your Code Asynchronous

// "async", the feature that allows you to write and call code asynchronously,
// was added in C# version 5.

// The C# async featues with improved new patterns and libraries, makes
// asynchronous programming much easier to write and work with than it was previously.

// Different perspectives of async that determine how you code:
// 1) library consumer = you make assumptions based on an implicit contract.
// 2) library creator = you have additional responsibilities to ensure your code provides the async contract users expect.

// Consuming Async Code
// C# keywords that support async:  async and await

// Decorating a method with the async modifier says that the method can contain async code.
// Using the await keyword on a Task starts an async operation.
using System.IO;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        Program.CreateFileAsync("test.txt").Wait();  // Note that Wait is ONLY used here because its a console application example.
        // Never call Wait(), use async and await instead in your normal coding of applications, etc.
    }


    public static async Task CreateFileAsync(string filename)
    {
        using (StreamWriter writer = File.CreateText(filename)) // curly braces required if multiple lines in the using statement block
            await writer.WriteAsync("This is a test.");
    }
}

// Above the CreateFileAsync method is asynchronous.

// Need to add using clause for the System.IO and Sytem.Threading.Tasks namespaces
// for writing a file and async Task support, respectively.
// File class is part of the FCL
// CreateText method returns a StreamWriter that you use to write to the file.

// Appending a method name with Async is not required, but it is a common convention.

// To call an async method use await its Task or Task<T>.
// WriteAsync method returns Task, which means you can await it.

// Async Return Types


// Use Task<T> when your method returns a value:
public async Task<string> ReturnGreeting()
{
    await Task.Delay(1000); // sleeps the thread for x milliseconds
    return "Hello";
}


// async void example:
public async void SayGreeting()
{
    await Task.Delay(1000);
    Console.WriteLine("Hello");
}

// This method executes asynchronously, but async void is not awaitable and they don't protect against exceptions.
// But async void is necessary for scenarios like event handling where the method must be void.
// Largest problem with async void methods:  You can't await and wrap it in a try-catch, so if an async method throws
// an unhandled exception, the application will crash.

// So why was async void added?  To support event handling.

// Developing Async Libraries

    // By default all code executes on the calling thread.  You need to marshal exectuion onto a thread and release
    // the calling thread to the caller.

// Understanding What Thread the Code is Running On

// This isn't a logical example, but represents the potential structure of some library code
// Should demonstrate what happens with threads before and after the first await in your async method.
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class UserInfo  // a type to hold and return data
{
    public string Info { get; set; }
    public string Address { get; set; }
}

class UserService // have async methods that the GetUserInfoAsync method calls
{
    internal static async Task<string> GetUserAsync(string user)
    {
        // Do some long running synchronous processing.
        return await Task.FromResult(user);
    }
}
class AddressService // have async methods that the GetUserInfoAsync method calls
{
    internal static async Task<string> GetAddressAsync(string user)
    {
        return await Task.FromResult(user);
    }
}

public class UserSearch
{
    public async Task<UserInfo> GetUserInfoAsync(string term, List<string> names)
    {
        var userName =
            (from name in names
             where name.StartsWith(term)
             select name)
            .FirstOrDefault();
        var user = new UserInfo();
        user.Info = await UserService.GetUserAsync(userName);
        user.Address = await AddressService.GetAddressAsync(userName);

        return user;
    }
}

// This is meant to represent reusable library code, so it could be called from a variety of different technologies
// for ex:  WPF, Windows Store apps, Windows Phone, etc.  Essentially all common applications in which a user interacts
// with UI controls and the UI controls fire events.  An async void event handler awaits your GetUserInfoAsync method.

// When the event handler code calls your code, it's initially running on the UI thread.  Your code will continue running on the
// UI thread until some other code explicitly marshals the call to another thread and releases the UI thread.

// To be more precise, the thread calling your code might not necessarily be the UI thread if there is another async method that called
// your code and already released the UI thread.  But, like driving...be defensive.  Defensive coding is a safe approach because there exists
// the possibility that your code will be called on the UI thread by some developer in the future.

// See above example:  awaiting Task.FromResult releases the UI thread and the rest of the code runs asynchronously.

// Fulfilling the Async Contract

// Whenever you call an async method in the FCL, that code will release the calling thread and continue on a new thread, which is proper
// behavior of the async contract that developers expect.  Your code should do the same (see below example).

// Use the Task.ConfigureAwait method, passing false as the parameter.  Below is an example that fixes the problem in GetUserInfoAsync:
public async Task<UserInfo> GetUserInfoAsync(string term, List<string> names)
{
    var userName =
        (from name in names
         where name.StartsWith(term)
         select name)
        .FirstOrDefault();

    var user = new UserInfo();
    user.Info = await UserService.GetUserAsync(userName).ConfigureAwait(false);
    user.Address = await AddressService.GetAddressAsync(userName);

    return user;

}

// GetUserInfoAsync method appends ConfigureAwait(false) to the call to GetUserAsync.
// GetUserAsync returns a Task<string> and ConfigureAwait(false) operates on that return value,
// releasing the calling thread and running the rest of the method on a new async thread.

// still have to keep issue of synchronous processing in mind and attempt to write the code in
// such a way that additional code and processes are not occurring until after the first await.
// And call ConfigureAwait(false) at the earliest opportunity, releasing the UI thread and running
// the remaining algorithm on the new async thread.