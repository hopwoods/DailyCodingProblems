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
