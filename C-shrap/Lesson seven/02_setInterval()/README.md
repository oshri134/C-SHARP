# setInterval(function, milliseconds)

setInterval() will execute the function in specific time intervals, in milliseconds.

- it will run, as long as the window is open.

> intervals - רווחים

### clearInterval()

clearInterval() can stop the setInterval().

> note: the clearInterval() function gets as parameter variable of setInterval().

```js
clearInterval(printData);
```

## class task - timer

- in html:

  - header - timer
  - 2 buttons of start and stop
  - div/h3 that will contain the timer

- in JS:
  - global variables: (define as `var`)
    - create an instance of class `Date`
    - interval
  - in start function: define by set() the hours, minutes, seconds to 0.
    - create a variable of type setInterval - that will insert the data to the HTML page, each second.
  - in stop function: stop the setInterval variable
