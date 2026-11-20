# Big O notes — Chapter 2

## Finding the minimum

- Why do I need to inspect every element?
because the array is unsorted and the minimum element might be the last one.

- For n elements, how many comparisons do I make?
n -1.

- Time complexity? O(n)

## Selection sort

- What does each pass do?
each pass find the smallest element alongside the whole remaining element.

- Why does the total work grow quadratically?
because for each element it should the whole remaining element. so => n(n - 1) / 2 and big O => O(n * n)

- Does an already-sorted input reduce the comparisons?
no.

- Time complexity? O(n * n)

## Extra space
- Why does my SelectionSort.Sort() use O(1) extra space?
Selection sort uses O(1) extra space because it sorts the existing array without creating another array.
It only needs a fixed number of variables, such as i, j, and minIndex, regardless of the input size. “I implement an array once” doesn’t explain that distinction

- Why does my Height Checker solution use O(n) extra space?
because I copy the array

## C# lesson
- How is assigning an array different from copying it with ToArray()?
assigning an array just assign the eference of that array and every change from each var also change the other var.
but with ToArray() just copy the value not the ref. the new var has its own ref.
