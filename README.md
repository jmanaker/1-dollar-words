# 1-dollar-words
This is a (*very*) old project from middle school.  It is at best a time capsule, showing my skills and the capabilities of the C# language and toolchain circa 2008.  Please do not submit pull requests; I will not accept them.  If you want to adapt the project to your own needs, fork a copy.  

The project began when I became friends with a teacher (Mrs. Yarborough) who mainly taught special-ed students and struggling writers.  (IIRC, she also organized the monthly math competition club, which is how I got to know her.)  She wanted to push her students to expand their vocabularies.  A crude measure for vocabulary size is her "dollar value" of each word: the longer a word, the more it is worth (greater detail below).  She could then exhort her students to use "more $1 words!" in their essays.  

The specific algorithm is values a word or phrase at the total (summed) value of its individual letters.  A letter at index k in the alphabet is worth k¢; thus 'b' is worth 2¢ and 'c' is worth 3¢.  In her original problem specification, she wanted vowels to cost money, so that 'a' is worth -1¢.  (I thought it might be useful not to count them as negative values.  There's an option to modify them to be positive/negative in the program settings.)  Appraising words by hand obviously requires great time and annoyance, so she wanted a computer program to do it for her.  

I don't know whether she received a lot of essays about syzygies afterwards.  
