# PRNG

Pseudo-random number generator algorithms require a seed to generate the sequence of semi-aleatory numbers.

## Linear Congruential Generator
 
This algorithm requires a set of arguments:
- Seed: It's the initial value
- Multiplier: It multiplies the current seed.
- Increment: It's the distance between two generated numbers.
- Modulus: It's the limit. When the next number is greater than the modulus, the modules restart the next number again.

The relation is:
<br>
<code>NextNumber = (Seed * Multiplier + Increment) mod Modulus</code>

## Advantages
Easy implementation and configuration of the parameters.
## Disadvantages
The effectiveness of the algorithm is based on the quality of the arguments. For example, is the multiplier and the increment are equal to 1, the sequence generated will be a simple list of contiguous number from the seed to the modulus, not random at all. If the seed is 0 and modulus is 10, so the sequence will be 1,2,3,4,5,6,7,8,9,0,1,2,3,4,...
