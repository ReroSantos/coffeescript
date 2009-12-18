# Functions:
square: x => x * x.

sum: x, y => x + y.

odd: x => x % 2 is 0.

even: x => x % 2 aint 0.

run_loop: =>
  fire_events( e => e.stopPropagation(). )
  listen()
  wait().

# Objects:
dense_object_literal: {one: 1, two: 2, three: 3}

spaced_out_multiline_object: {
  pi: 3.14159
  list: [1, 2, 3, 4]
  regex: /match[ing](every|thing|\/)/gi
  three: new Idea()

  inner_obj: {
    freedom: => _.freedom().
  }
}

# Arrays:
stooges : [{moe: 45}, {curly: 43}, {larry: 46}]

exponents : [x => x., x => x * x., x => x * x * x.]

empty: []

multiline: [
  'line one'
  'line two'
]

# Conditionals and ternaries.
if submarine.shields_up
  full_speed_ahead()
  fire_torpedos()
else
  run_away().

eldest: if 25 > 21 then liz else marge.

decoration: medal_of_honor if war_hero

go_to_sleep() unless coffee

# Returning early:
race: =>
  run()
  walk()
  crawl()
  if tired then return sleep().
  race().

# Conditional assignment:
good ||= evil
wine &&= cheese

# Nested property access and calls.
((moon.turn(360))).shapes[3].move({x: 45, y: 30}).position['top'].offset('x')

a: b: c: 5

# Embedded JavaScript.
callback(
  `function(e) { e.stop(); }`
)

# Try/Catch/Finally/Throw.
try
  all_hell_breaks_loose()
  dogs_and_cats_living_together()
  throw "up"
catch error
  print( error )
finally
  clean_up().

try all_hell_breaks_loose() catch error print(error) finally clean_up().

# While loops, break and continue.
while demand > supply
  sell()
  restock().

while supply > demand then buy().

while true
  break if broken
  continue if continuing.

# Unary operators.
!!true

# Lexical scoping.
a: 5
change_a_and_set_b: =>
  a: 10
  b: 15.
b: 20

# Array comprehensions.
supper: food.capitalize() for food in ['toast', 'cheese', 'wine'].

drink(bottle) for bottle, i in ['soda', 'wine', 'lemonade'] if even(i).

# Switch statements ("else" serves as a default).
switch day
case "Tuesday"   then eat_breakfast()
case "Sunday"    then go_to_church()
case "Saturday"  then go_to_the_park()
case "Wednesday"
  eat_breakfast()
  go_to_work()
  eat_dinner()
else go_to_work().

# Semicolons can optionally be used instead of newlines.
wednesday: => eat_breakfast(); go_to_work(); eat_dinner(); .

# Array slice literals.
zero_to_nine: [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
three_to_six: zero_to_nine[3, 6]

# Multiline strings with inner quotes.
story: "Lorem ipsum dolor \"sit\" amet, consectetuer adipiscing elit,
sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna
aliquam erat volutpat. Ut wisi enim ad."

# Calling super from an overridden method.
Greeter: => .                                            # Create the parent object.
Greeter.prototype.hello: name => alert('Hello ' + name). # Define a "hello" method.
Exclaimer: name => this.name: name.                      # Create the child object.
Exclaimer.prototype: new Greeter()                       # Set the child to inherit from the parent.
Exclaimer.prototype.hello: => super(this.name + "!").    # The child's "hello" calls the parent's via "super".
(new Exclaimer('Bob')).hello()                           # Run it.

# Numbers.
a_googol:   1e100
hex:        0xff0000
negative:   -1.0
infinity:   Infinity
nan:        NaN

# Deleting.
delete secret.identity