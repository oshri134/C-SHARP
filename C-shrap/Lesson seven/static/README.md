# Static constructor

- static constructor is in class level.
- it will run first automatically, one-time, before any instance is created.
- It cannot take any arguments.(it can change static variables.)
- A class can have only one static constructor. (it cannot have parameters inside the (). )

## static class

- cannot be derived from. (inheritance)
- Cannot create instance of static class
- All data must be static:
  - properties (private + public)
  - methods
  - constructor

> built-in static classes: Math, Console
