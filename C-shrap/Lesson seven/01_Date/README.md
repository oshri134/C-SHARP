# Date object

The date object works with date + time.

## Constructor:

```js
let d1 = new Date();
let d1 = new Date(milliseconds); // 1000 milliseconds = 1 second, goes from the default count year.
let d1 = new Date(date string);
new Date(year, month, day, hours, minutes, seconds)
```

### getDate()

returns the day of the month (1-31).

### getMonth()

is an array, starts counting from 0. to get the real month - add 1.

## toLocaleDateString(), toLocaleTimeString()

get the date / the time for an instance of object Date:

```js
const d = new Date();
d.toLocaleDateString(); // 1.9.2020
d.toLocaleTimeString(); // 15:45:17
```

## set()

set functions can define the date / time for date instance

```js
d.setHours(15);
d.setMinutes(45);
```
