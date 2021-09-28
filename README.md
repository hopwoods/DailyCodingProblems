# Daily Coding Problem Solutions

This is collection of .Net solutions to problems set by Daily Coding Problems. They are interview questions set by the likes of Google, Facebook, Amazon, etc.

---

## Daily Coding Problem - PrefixMapSum
This problem was asked by Google.

Implement a PrefixMapSum class with the following methods:

- **`insert(key: str, value: int)`**: Set a given key's value in the map. If the key already exists, overwrite the value.
- **`sum(prefix: str)`**: Return the sum of all values of keys that begin with a given prefix.

For example, you should be able to run the following code:

```c#
mapsum.insert("columnar", 3)
assert mapsum.sum("col") == 3

mapsum.insert("column", 2)
assert mapsum.sum("col") == 5
```
[Solution](https://github.com/hopwoods/DailyCodingProblems/tree/master/PrefixMapSum)

## Daily Coding Problem - Rand5()
This problem was asked by Two Sigma.

Using a function `rand7()` that returns an integer from 1 to 7 (inclusive) with uniform probability, implement a function `rand5()` that returns an integer from 1 to 5 (inclusive).

[Solution](https://github.com/hopwoods/DailyCodingProblems/tree/master/Rand5)

## Daily Coding Problem - Binary Tree Deepest Node
This problem was asked by Google.

Given the root of a binary tree, return a deepest node. For example, in the following tree, return d.
```
    a
   / \
  b   c
 /
d
```

[Solution](https://github.com/hopwoods/DailyCodingProblems/tree/master/BinaryTree)

## Roman Numerals

Write a function to convert Arabic numbers to Roman numerals.

Given a positive integer number (for example, `42`), determine its Roman numeral representation as a string (for example, `XLII`).

> Examples:
>
>
> *Simple numbers*
>| Arabic | Roman | Arabic | Roman |
>| ------ | ----- | ------ | ----- |
>| 1      | I     | 60     | LX    |
>| 2      | II    | 70     | LXX   |
>| 3      | III   | 80     | LXXX  |
>| 4      | IV    | 90     | XC    |
>| 5      | V     | 100    | C     |
>| 6      | VI    | 200    | CC    |
>| 7      | VII   | 300    | CCC   |
>| 8      | VIII  | 400    | CD    |
>| 9      | IX    | 500    | D     |
>| 10     | X     | 600    | DC    |
>| 20     | XX    | 700    | DCC   |
>| 30     | XXX   | 800    | DCCC  |
>| 40     | XL    | 900    | CM    |
>| 50     | L     | 1000   | M     |
>

>*Composed Numbers*
>
>| Arabic | Roman    | Thousands | Cents | Tenths | Units |
>| ------ | -------- | --------- | ----- | ------ | ----- |
>| 846    | DCCCXLVI | -         | DCC   | XL     | VI    |
>| 1999   | MCMXCIX  | M         | CM    | XC     | IX    |
>| 2008   | MMVIII   | MM        | -     | -      | VIII  |

[Solution](https://github.com/hopwoods/DailyCodingProblems/tree/master/RomanNumeralCalculator