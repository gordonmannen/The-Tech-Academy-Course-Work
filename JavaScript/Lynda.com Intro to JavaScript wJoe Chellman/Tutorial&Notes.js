var x = 32;
x;

var whereAmI = "Graz, Austria";
whereAmI;

x = 45;
x;
whereAmI = 75;
whereAmI;

var monster1 = "Grover", monster2 = 'Cookie Monster', monster3 = 'Animal';
monster1;
monster2;
monster3;

var presidentOfUSA = "Obama"; // as of late summer 2012
presidentOfUSA;

12
12.0
12.82358972893527582
- 12
Infinity
- Infinity
NaN

Math;
Math.round(12.92309820948209384);
Math.round(12.4984012840918);

Math.random();
Math.random();
Math.random();
Math.random();

"This is a string";
"12";
12;

'This is also a string';
'This is a string"; // mismatched quotes - this will not execute

'<a href="">';
'<a href="http://www.example.com">';

"This is Joe's favorite string";
"This is Joe's \"favorite\" string";
"This is Joe's "favorite" string"; // this line will not work

var myString = "This is my string. Leave it alone";
myString;
myString.length;
myString.toUpperCase();

"This is my string".length;

true;
false;

True;
FALSE;
tRuE;
true;
false;

var myLocation = "Graz", myOtherLocation = "Los Angeles";

myLocation === myOtherLocation;

myOtherLocation = "Graz";

myLocation === myOtherLocation;

12;
"strings";
true;

{};
var emptyObject = {};
emptyObject;


var notEmptyObject = {
    'label' : 'value',
    'label2' : 'value2'
};
notEmptyObject;

var animal = {
    'genus' : 'bird',
    'species' : 'raven',
    'callType' : 'squawky', // there is a deliberate bug here in the course, removed for your convenience :)
    'quote' : 'Nevermore',
    'maxOffspring' : 5,
    'noisy' : true,
    'deadly' : false
};

var animal2 = {
    'genus' : 'bear',
    'species' : 'grizzly',
    'callType' : 'roar',
    'quote' : '',
    'maxOffspring' : 3,
    'noisy' : true,
    'deadly' : true
};

var bookOfKnowledge = {
    'lunch time' : '12:30 PM',
    'the ultimate answer' : 42,
    'bestSong' : 'Lonnie\'s Lament',
    'earth' : 'Mostly harmless.'
};

var animal = {
    'genus' : 'bird',
    'species' : 'raven',
    'callType' : 'squawky',
    'quote' : 'Nevermore',
    'maxOffspring' : 5,
    'noisy' : true,
    'deadly' : false
};

animal.quote;

animal."quote"; // this does not work

animal["quote"];

animal.color = "black";

animal;

animal["where it lives"] = "in a tree";
animal.whereItLives = "in a tree";
animal.whereItLives;
animal['whereItLives'];

delete animal.color;
animal;

var emptyObject = {};
emptyObject.isItReallyEmpty = false;
emptyObject;

animal;

var animal = {
    'genus' : 'bird',
    'species' : 'raven',
    'callType' : 'squawky',
    'quote' : 'Nevermore',
    'maxOffspring' : 5,
    'noisy' : true,
    'deadly' : false
};
animal;

var animal2 = animal;
animal2;

animal2.genus = 'bear';
animal2;
animal;

var animal2 = {
    'genus' : 'bird',
    'species' : 'raven',
    'callType' : 'squawky',
    'quote' : 'Nevermore',
    'maxOffspring' : 5,
    'noisy' : true,
    'deadly' : false
};

animal2.genus = 'bear';
animal2;
animal;

var myArray = [];
myArray;

var daysOfTheWeek = ['Sunday', 'Monday', 'Tuesday', 'Wednesday'];
daysOfTheWeek;

var myArray = [
0, 1, 2,
'string1', 'string2', 'string3',
true, false
];
myArray;

var counties = [
	'Belknap',
	'Strafford',
	'Carroll',
	'Rockingham'
];
counties;

var arrayOfStuff = [
	{'name' : 'value'},
	[1, 2, 3],
	true,
	'nifty'
];
arrayOfStuff;
arrayOfStuff.length;

var counties = [
	'Belknap',
	'Strafford',
	'Carroll',
	'Rockingham'
];

counties[0];
counties[2];

counties[2] = 'Cheshire';
counties;

counties[4] = 'Carroll';
counties;

counties[counties.length] = 'Merrimack';
counties;

counties.push('Coos');
counties;

counties.pop();

delete counties[2];
counties;

counties.splice(2, 1);
counties;
counties.length;

var year=2012,month='October',day=31,holiday='Halloween';

var year   = 2012,       month    =    'October', day =          31,          holiday='Halloween';

var year = 2012,
	month = 'October',
	day = 31,
	holiday = 'Halloween';
	
var year    = 2012,
	month   = 'October',
	day     = 31,
	holiday = 'Halloween';

var tinyAlmanac={'year':2012,'month':'October','day':31,'holiday':'Halloween'};

var tinyAlmanac = {
    'year' : 2012,
    'month' : 'October',
    'day' : 31,
    'holiday' : 'Halloween'
};

// another after the slashes does not execute
var year = 2012,
	month = 'October', // this is the month
	day = 31,
	holiday = 'Halloween';

/*
You can write comments
across multiple lines
finally ending with:
*/

var tinyAlmanac = {
    'year' : 2012,
    'month' : 'October',
    'day' : 31,
    'holiday' : 'Halloween'
};

var string1 = 'This is the longest string ever.';
var string2 = 'This is the shortest string ever.';
var string3 = 'Is this the thing called Mount Everest?';
var string4 = 'This is the Sherman on the Mount.';

var regex = /this/;

console.log( regex.test(string1) );
console.log( regex.test(string2) );
console.log( regex.test(string3) );
console.log( regex.test(string4) );

regex = /this/i;

regex = /^this/i;

regex = /this$/i;

regex = /ever.$/i;

regex = /ever\.$/i;

regex = /Moun.$/i;

1 === 1;  // true
1 !== 1;  // false
1 !== 2;  // true
1 === 2;  // false

1 == 1; // true
1 == '1'; // true (?!)
1 === '1'; // false 
1 != '1'; // false

1 < 2; // true

1 > 2; // false

1 <= 2; // true

1 <= 1; // true

1 >= 2; // false

10 >= 2; // true

2 + 5;
4 - 3;
5 - 9;
3 * 5;
36 / 6;
36 / 5;

20 % 2;
19 % 2;

var counter = 0;
counter = counter + 1;
counter;

counter += 1;
counter++;

counter += 5;
counter += -4;

counter -= 1;
counter--;
counter;

counter *= 2;

"cat" + "dog";
"cat " + "dog";
"cat" + " and " + "dog";

var animal1 = 'monkey';
var animal2 = 'bear';
var animal3 = 'tiger';

animal1 === 'monkey' && animal2 === 'bear'; // true

animal1 === 'ape' && animal2 === 'bear'; // false

animal1 === 'ape' && animal2 === 'bear' && animal3 === 'tiger'; // false

animal1 === 'monkey' && animal2 === 'bear' && animal3 === 'tiger'; // true

animal1 === 'monkey' || animal2 === 'bear'; // true

animal1 === 'ape' || animal2 === 'bear'; // true

animal1 === 'ape' || animal2 === 'ostrich'; // false

animal1 === 'monkey' || animal2 === 'bear' && animal3 === 'tiger'; // true

animal1 === 'ape' || animal2 === 'bear' && animal3 === 'tiger'; // true

(animal1 === 'ape' || animal2 === 'monkey') && animal3 === 'tiger'; // false

animal1 === 'monkey' && animal2 === 'bear'; // true

!(animal1 === 'monkey' && animal2 === 'bear'); // false

var answer = window.confirm('Click OK, get true.  Click cancel, get false.');
answer;

if (answer === true) {
    console.log('You said true!');
}

if (answer === true) {
    console.log('You said true!');
} else {
    console.log('You said something else');
}

var answer = window.prompt('Type YES, NO, or MAYBE.  Then click OK.');
if (answer === 'YES') {
    console.log('You said YES!');
} else if (answer === 'MAYBE') {
    console.log("You said maybe. I don't know what to make of that."); // note the double primes
} else if (answer === 'NO') {
    console.log('You said no. :(');
} else {
    console.log('You rebel, you!');
}

var answer = window.prompt('Type YES, NO, or MAYBE.  Then click OK.');
if (answer === 'YES' || answer === 'NO') {
    console.log('You said YES!');
} else if (answer === 'NO') {
    console.log('You said no. :(');
} else {
    console.log('You rebel, you!');
}

var answer = window.prompt('Type YES, NO, or MAYBE.  Then click OK.');

switch (answer) {
    case 'YES' :
        console.log('You said YES!');
        break;
    case 'MAYBE' :
        console.log("You said maybe. I don't know what to make of that.");
        break;
    case 'NO' :
        console.log('You said no. :(');
        break;
    default :
        console.log('You rebel, you!');
        break;
}

var cherub = 'Cupid';
// cherub = 'Some Other Guy';

if (cherub === 'Cupid') console.log("Ouch, an arrow!  Ooo, I'm in love!");


if (cherub === 'Cupid')
    console.log("Ouch, an arrow!  Ooo, I'm in love!");
else
    console.log("I feel nothing!");

var wantForChristmas = 'puppy',
	gotForChristmas = 'puppy',
	cryAboutIt = false;

if (wantForChristmas === gotForChristmas) {
    console.log('Yay! The little children are so pleased!');
    cryAboutIt = false;
} else {
    console.log('Oh no! Sad Christmas!');
    cryAboutIt = true;
}

if (cryAboutIt) {
    console.log('Child says: WAAAAAAAAAAAAAAAAAAAAAAAAA!');
}


var animal = 'cat';
// animal = 'dog';

animal === 'cat' ? console.log('You will be a cat herder.') : console.log('You will be a dog catcher.');

var job = (animal === 'cat' ? 'cat herder' : 'dog catcher');

var thing = 12;
thing = 'twelve';
typeof thing;

thing = 12;
typeof thing;

thing = false;
typeof thing;

thing = {};
typeof thing;

thing = [];
typeof thing;
typeof thing === 'object' && thing.hasOwnProperty('length'); // true

thing = {};
typeof thing === 'object' && thing.hasOwnProperty('length'); // true

NaN;
typeof NaN;

typeof null;
thing === null;
thing = null;
thing;
thing === null;

for (var i = 0; i < 10; i += 1) {
    console.log(i);
}

// very common use case: looping over an array.
var pageNames = ['Home', 'About Us', 'Contact Us', 'JavaScript Playground', 'News', 'Blog'];
for (i = 0; i < pageNames.length; i += 1) {
    if (document.title == pageNames[i]) {
        console.log('We ARE here: ' + pageNames[i]);
    } else {
        console.log('We are not here: ' + pageNames[i]);
    }
}

// don't repeat yourself:
var pageNames = ['Home', 'About Us', 'Contact Us', 'JavaScript Playground', 'News', 'Blog'];
for (i = 0; i < pageNames.length; i += 1) {
    var currentPageTitle = pageNames[i];

    if (document.title == currentPageTitle) {
        console.log('We ARE here: ' + currentPageTitle);
    } else {
        console.log('We are not here: ' + currentPageTitle);
    }
}

// iterate over an array
var pageNames = ['Home', 'About Us', 'Contact Us', 'JavaScript Playground', 'News', 'Blog'];
for (var p in pageNames) {
    console.log(p + ' is ' + pageNames[p]);
}

// iterate over an object
var pages = {
    'first' : 'Home',
    'second' : 'About Us',
    'third' : 'Contact Us',
    'fourth' : 'JavaScript Playground',
    'fifth' : 'Blog',
};
for (var p in pages) {
    if (pages.hasOwnProperty(p)) {
        console.log(p + ' is ' + pages[p]);
    }
}

// for loop
for (var i = 0; i < 10; i++) {
    console.log(i);
}

// same thing as a while loop
var i = 1;
while (i < 10) {
    console.log(i + '... This will go until we hit 10');
    i += 1;
}



var myArray = [true, true, true, false, true, true];

var myItem = null;
while (myItem !== false) {
    console.log('myArray has ' + myArray.length + ' items now. This loop will go until we pop a false.');
    myItem = myArray.pop();
}


var counter = 1;
while(true) {
    console.log(counter);
    counter++;
    break; // comment out this break statement to make this loop go forever and potentially lock up your web browser
}



var myArray = [true, true, true, false, true, true];

var myItem = false;
do {
    console.log('myArray has ' + myArray.length + ' items now. This loop will go until we pop a false.');
    myItem = myArray.pop();
} while (myItem !== false);

console.log('Arf');
console.log('Woof');
console.log('Meow');
console.log('Moooooooooooo');

function speak() {
    console.log('Arf');
    console.log('Woof');
    console.log('Meow');
    console.log('Moooooooooooo');
}

speak();

fuddify("Be very quiet, I'm hunting rabbits.");
fuddify("You screwy rabbit.");
fuddify("Rabbit tracks!");

function fuddify(speech) {
    // if it's not a string, return an error message
    if (typeof speech !== 'string') return "Nice twy, wabbit!";
	
    // otherwise, make it sound like Elmer Fudd
    speech = speech.replace(/r/g, 'w');
    speech = speech.replace(/R/g, 'W');
	
    return speech;
}

var utterance = fuddify("You screwy rabbit");
utterance;

function isOdd(num) {
    if (num % 2 === 0) {
        return false;
    } else {
        return true;
    }
}

12 % 2;
isOdd(45);

function speakSomething(what, howMany) {
    // this pattern works nicely for default values:
    // check if the argument is undefined, and if it is, provide a default value
    var what = (typeof what !== 'undefined') ? what : 'Default speech';
    var howMany = (typeof howMany !== 'undefined') ? howMany : 10;
	
    for (var i = 0; i < howMany; i += 1) {
        console.log(what + " (" + i + ")");
    }
}

speakSomething('Hey hey', 5);
speakSomething('Hey hey');
speakSomething();

function addingMachine() {
    // initialize the total we'll be returning
    var total = 0;
	
    for (var i = 0; i < arguments.length; i += 1) {
        // grab the next number
        var number = arguments[i];
		
        // check if the argument is a number.
        // if so, add it to the running total
        if (typeof number === 'number') {
            total += number;
        }
    }
	
    // done - return the total
    return total;
}

addingMachine(1,2,3);
addingMachine(1,2,3,4,5,6,7,8,9,1204910249014);

var calvin = {
    'name' : 'Calvin',
    'bestFriend' : 'Hobbes',
    'name' : 'Calvin',
};

// you can also pass an object to a function
// because objects are passed by reference, the argument will be modified
function transmogrifier(calvin) {
    if (typeof calvin !== 'object') {
        console.log('argument is of the wrong type');
        return;
    }

    // generate a random number between 1 and 5
    var randomNumber = Math.floor(Math.random() * 5) + 1;
  
    switch(randomNumber) {
        case 1 :
            calvin.form = 'tyrannosaurus';
            break;
        case 2 :
            calvin.form = 'grey wolf';
            break;
        case 3 :
            calvin.form = 'bengal tiger';
            break;
        case 4 :
            calvin.form = 'grizzly bear';
            break;
        case 5 :
            calvin.form = 'canary';
            break;
        default :
            // do nothing - he stays human
            break;
    }
}

// this version of the transmogifier does return a copy, leaving the original alone
function transmogrifyCopy(calvin) {
    if (typeof calvin !== 'object') {
        console.log('argument is of the wrong type');
        return;
    }

    // generate a random number between 1 and 5
    var randomNumber = Math.floor(Math.random() * 5) + 1;
    var newForm = calvin.form; // by default, do not change
  
    switch(randomNumber) {
        case 1 :
            newForm = 'tyrannosaurus';
            break;
        case 2 :
            newForm = 'grey wolf';
            break;
        case 3 :
            newForm = 'bengal tiger';
            break;
        case 4 :
            newForm = 'grizzly bear';
            break;
        case 5 :
            newForm = 'canary';
            break;
        default :
            // do nothing - he stays human
            break;
    }
  
    // return a new object that's just like calvin,
    // but transmogrified!
    return {
        'name' : calvin.name,
        'bestFriend' : calvin.bestFriend,
        'form' : newForm
    };
}

function speakSomething (what) {
    for (var i = 0; i < 10; i += 1) {
        console.log(what);
    }
}

var speakSomething = function(what) {
    for (var i = 0; i < 10; i += 1) {
        console.log(what);
    }
}

window.setTimeout(speakSomething, 5000);

var obj = {
    'function' : function() {
        console.log('Hello');
    }
};

obj.function();

var myNum = 32;
var myResult = 'Success!';

function randomizer(limit) {
    var myNum = Math.floor(Math.random() * limit);
	
    console.log('myNum is ' + myNum);
    console.log('Global myNum is ' + window.myNum);
	
    return myNum;
}

randomizer(10);





