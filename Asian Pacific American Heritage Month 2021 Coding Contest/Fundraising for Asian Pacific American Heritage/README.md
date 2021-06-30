## Problem

In a fundraising challenge for Asian Pacific American Heritage Month, given the initial setup of a mathematical game between two players, you are required to evaluate the outcome of the match. Every correct evaluation equals a 100$ donation to a non-profit working towards celebrating and protecting Asian Pacific Heritage in the United States.

There are two players in the game and there is a number sequence of size n. The game lasts for n rounds. Players alternate turns and the first player starts the game. Each round, the corresponding player removes the first number from the sequence and adds its value to his/her score. After that, if the ‘removed’ number is even, the remaining sequence is reversed.

Determine the difference in scores between the two players after the game.

More precisely, suppose first_score and second_score are the final scores of the first and second player respectively. You need to calculate the value of first_score – second_score.

### Example

Consider the number of elements to be n = 5 and the number sequence to be numSeq = [3, 6, 2, 3, 5].
- 1st round:  First player picks 3, first_score = 3. The remaining sequence: [6, 2, 3, 5].
- 2nd round:  Second player picks 6, second_score = 6. The remaining sequence is reversed (since 6 is even): [5, 3, 2].
- 3rd round:  First player picks 5, first_score = 3 + 5 = 8. The remaining sequence: [3, 2].
- 4th round:  Second player picks 3, second_score = 6 + 3 = 9. The remaining sequence: [2].
- 5th round (final): First player picks 2, second_score = 8 + 2 = 10. The remaining sequence: [].
 
The total difference between players’ scores will be 1 since first_score = 10 and second_score = 9, i.e, 10 – 9 = 1.
Function Description

Complete the function getScoreDifference in the editor below.

getScoreDifference has the following parameter:

numSeq: the given array of integers

Returns
    int: the difference between the scores of first and last players

#### Constraints
- 1 ≤ n ≤ 105
- 1 ≤ numSeq[i] ≤ 104 for each 0 ≤ i < n

Input Format For Custom Testing
The first line contains an integer, n, that denotes the number of elements in the scores array.

Each line i of the n subsequent lines (where 0 ≤ i < n) contains integer that describes numSeq[i].

### Sample Case 0

Sample Input For Custom Testing

#### STDIN → FUNCTION
    4        →    numSeq[] size n = 4
    2        →    numSeq = [2, 1, 4, 3]
    1
    4
    3

#### Sample Output
    2

####  Explanation
The game proceeds as follows:
- 1st round:  First player picks 2, first_score = 2. The remaining sequence is reversed (since 2 is even): [3, 4, 1].
- 2nd round:  Second player picks 3, second_score = 3. The remaining sequence: [4, 1].
- 3rd round:  First player picks 4, first_score = 2 + 4 = 6. The remaining sequence: [1].
- 4th round (final):  Second player picks 1, second_score = 3 + 1 = 4. The remaining sequence: [].
The total difference between players’ scores will be 2 since first_score = 6 and second_score = 4, i.e, 6 – 4 = 2.

### Sample Case 1

Sample Input For Custom Testing

#### STDIN → FUNCTION
    2        →    numSeq[] size n = 4
    2        →    numSeq = [2, 2]
    2

#### Sample Output
    0

####  Explanation
Both the players pick equal element (equal to 2) in their turns, thus the score difference is 0.
