# This is a simple demonstration of Bubble Sort in C#

Bubble Sort is the simplest Sorting Algorithm that repeatedly compare 2 elements and swapping the adjacent elements when there are not in the correct order.

For Example:
Given an array of: [5, 9, 7, 4]
And a condition of swapping element when [i] > [i+1]

First Scan: 
[**5**, **9**, 7, 4]    5 > 9 = False; no changes.
[5, **9**, **7**, 4]    9 > 7 = True; swap.
[5, 7, **9**, **4**]    9 > 4 = True; swap.
[5, 7, 4, 9]

Second Scan:
[**5**, **7**, 4, 9]    5 > 7 = False; no changes.
[5, **7**, **4**, 9]    7 > 4 = True; swap
[5, 4, **7**, **9**]    7 > 9 = False; no changes.
[5, 4, 7, 9]

Third Scan:
[**5**, **4**, 7, 9]    5 > 4 = True; swap
[4, **5**, **7**, 9]    5 > 7 = False; no changes;
[4, 5, **7**, **9**]    7 > 9 = False; no changes;
[4, 5, 7, 9]

The values are now sorted in order, but Bubble Sort require one additional scan without any swap to conclude the data are sorted.

Fourt Scan: No Swap
[**4**, **5**, 7, 9]
[4, **5**, **7**, 9]
[4, 5, **7**, **9**]
[4, 5, 7, 9]

This example demonstrate that the Bubble Sort will always runs at O(n^2) even if it is a sorted data.

| x | x | x |
|---|---|---|
| Worst and Average Case Time Complexity | O(n*n) | Worst case occurs when array is reverse sorted|
| Best Case Time Complexity | O(n) | Best case occurs when array is already sorted |
| Auxiliary Space | O(1) |  |
| Boundary Cases | Takes minimum time (Order of n) when elements are already sorted |  |
| Sorting in Place | Yes |  |
| Stable | Yes |  |