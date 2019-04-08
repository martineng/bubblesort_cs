# Bubble Sort in C#
Bubble Sort is the simplest Sorting Algorithm that repeatedly compare 2 elements and swapping the adjacent elements when there are not in the correct order.<br />
<br />
For Example:<br />
Given an array of: [5, 9, 7, 4]<br />
And a condition of swapping element when [i] > [i+1]<br />
<br />
First Scan: <br />
[**5**, **9**, 7, 4]    5 > 9 = False; no changes. <br />
[5, **9**, **7**, 4]    9 > 7 = True; swap. <br />
[5, 7, **9**, **4**]    9 > 4 = True; swap. <br />
[5, 7, 4, 9] <br />
<br />
Second Scan: <br />
[**5**, **7**, 4, 9]    5 > 7 = False; no changes.<br />
[5, **7**, **4**, 9]    7 > 4 = True; swap<br />
[5, 4, **7**, **9**]    7 > 9 = False; no changes.<br />
[5, 4, 7, 9]<br />
<br />
Third Scan:<br />
[**5**, **4**, 7, 9]    5 > 4 = True; swap<br />
[4, **5**, **7**, 9]    5 > 7 = False; no changes;<br />
[4, 5, **7**, **9**]    7 > 9 = False; no changes;<br />
[4, 5, 7, 9]<br />
<br />
The values are now sorted in order, but Bubble Sort require one additional scan without any swap to conclude the data are sorted.<br />
<br />
Fourt Scan: No Swap<br />
[**4**, **5**, 7, 9]<br />
[4, **5**, **7**, 9]<br />
[4, 5, **7**, **9**]<br />
[4, 5, 7, 9]<br />
<br />
This example demonstrate that the Bubble Sort will always runs at O(n^2) even if it is a sorted data.<br />

| x | x | x |
|---|---|---|
| Worst and Average Case Time Complexity | O(n*n) | Worst case occurs when array is reverse sorted|
| Best Case Time Complexity | O(n) | Best case occurs when array is already sorted |
| Auxiliary Space | O(1) |  |
| Boundary Cases | Takes minimum time (Order of n) when elements are already sorted |  |
| Sorting in Place | Yes |  |
| Stable | Yes |  |
