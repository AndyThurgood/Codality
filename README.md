# Codility
Solution that covers a number of codility Tests. (www.codility.com)

Examples built using a few coding languages that include:

* C#
* Python
* Go

Mostly hitting the 100% benchmark, handful fall down in terms of performance (C# in the main).

No real consideration for NFR's in these solutions (not needed), so purposely missing exception handling, logging and OO/abstraction.

May come back to this and do the remaining tests in the future.

### Hints and tips
When I first took a look at the codility exercises I found them to be a bit of head scratcher, the way that the online IDE works, the way that the exercise requirements are written and how to test your solution all seemed a bit odd. You have spen a fair amount of time working on a number of the exercises before you really get into the swing of things and get used to meeting all of the codility requirements, for anyone atempting the exercieses,  my advise would be as follows:

* Read the exercise requirements through a number of times, try and get a clear view on what is required and what outputs are expected
* Ensure the provided test cases pass
* Think about edge cases and test those
* Ensure you have catered for exception scenarios (empty arrays, zero/null values) an return the correct default value
* Ensure you check for min/max value scenarios
* Read the requirements yet again

On a couple of occaisons I was tempted to hit the complete button (typically as soon as the test cases passed), however it is wise to then take a step back an re-review the above before assuming all is well.

### What do we think of codility?

As someone that is often faced with a need to recruit new techies, I'm not sold on the use of a test framework such as codility, after tackling some of the exercises I thought I'd accompany them with some thoughts. 

Searching the web for opinions on codility returns common themes (e.g. IDE usage, time pressures, unclear requirements), for me the repetitive nature of the test made this a bit of a chore, coupled with the fact that (by far!) the most challenging part of the writing these solution was actually understanding the problem, left me unconvinced.

Given that nearly all of the exercises can be solved via either a pure math function or simple enumeration logic, putting myself in the recruitment seat I'd be looking to gauge more than a persons ability to write logical code. Can the candidate put together an actual working solution? how about their approach to testing? Do they do a good job of exception handling and logging? (most of these are non-functional in nature).

Obviously the codility test are designed to be coupled/augmented with a typical recruitment process, however I'd prefer to give someone a deliverable that they can build themselves in order to get a real glimpse into how they approach a problem, such an approach provides:

* A view on their coding style;
* Can they take a requirement a produce valid code outputs;
* How much attention is paid to the NFR's;
* Are they writing code the stands out?

Typically, when looking at how someone approaches a coding exercise I can gauge pretty quickly where some sits on the scale of ok --> great, the very structured nature of the codility tests means you would struggle to understand the broader picture of how someone writes code.

In summary, I'm not hating on codility - I found some of the exercises tricky whilst also interesting (helping me to refresh my Linq skills and also power up both my python and Go levels in the process). I can see why people may want to have this as a recruitment gate, providing a very quick way to evaluate someones code skills, however I can't get away from the fact it may not tell a complete picture which could lead hiring the wrong people and even missing out on the right.
