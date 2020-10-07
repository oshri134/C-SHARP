# lesson 03 

## matrix - 2 dimentional array. 
there are 3 ways to initialize matrix (similar to array). 

* example: 
```cs
string[][] matrix2 = new string[2][] { new string[] { "a", "b"}, new string[] { "c", "d" } };

```

## for vs foreach

for loop - goes on index. to access item: 
* array: ```arr[index]```
* matrix: ```mat[row][col]```

foreach loop - goes on value. 
```cs
foreach (int item in arr)
{
    Console.Write(item);
}
```

## Jagged array - מערך משונן
each row can have diffrent amount of items. 
```cs
int[][] ja = new int[2][]
{
    new int[3];
    new int[18];
}
```