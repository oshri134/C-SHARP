# Static 

**static** is a keyword in C#. it can be used with:
1. class
2. variables - is in the class level. can contain global data
3. methods - the only way to access static method - is by the class's name
4. constructor


## static class:
* In a non-static class we can have both static and non-static members. 
* In a static class - all members must be static(properties, methods, constructors)
* We cannot create instances from a static class. 

> Note: if a member is static, the access is by the class name: (no need to define an instance at all)
* access non-static : by instance name:
```cs
instanceName.propName;
instanceName.MethodName();
```
* access static : by class name:
```cs
className.propName;
className.MethodName();
```
#### Examples of built-in static classes in .NET:
1. Math
2. Console

> note: reach class definition by: F12

### class task - avg grade of all students:
* create student class. 
* create 2 static properties: sumGrade, and NumOfStudents
* create 1 property: grade, and add validation check: 1-100. 
* add the constructor
* create a method - to get the total average grade of all the students. 