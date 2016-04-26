# Before Sort
my_list = [67,45,2,13,1,998]
print(my_list)



# After Sort
def selectionSort(my_list):
    for fillslot in range(len(my_list)-1, 0, -1):
        positionOfMax=0
        for location in range(1,fillslot+1):
            if my_list[location]>my_list[positionOfMax]:
                positionOfMax = location

        temp = my_list[fillslot]
        my_list[fillslot] = my_list[positionOfMax]
        my_list[positionOfMax] = temp

my_list = [67,45,2,13,1,998]
selectionSort(my_list)
print(my_list)
# Effectively the selection sort goes through the values from left to right
# and sorts them by moving the largest value to the right and then performing
# another pass, but ignoring that rightmost position as it is already set.  It
# keeps passing until all of the values are in order of smallest to largest value.
