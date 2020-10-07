# Lesson 02

## ToString()
ToString() function will insert to string variable, a diffrent type of variable. 
```cs
int num1 = 265;
string str1 = num1.ToString(); // "256"
```

## Casting

### Implicit casting - המרה מרומזת
will happen when there is no data loss. from small number to big number. 

```cs
int1= byte1;
```

### explicit casting - המרה מפורשת
will happen when we can lose data. from big number to small number. 
We must tell the program that we are aware of it by adding conversion:
```cs
byte1 = (byte)int1;
```
