{-
--1
absWith5 n = abs n + 5

main = do
    putStr "Enter number: "
    s1 <- getLine
    let num = read s1 :: Int 
    print (show (absWith5 num))

--2
pass3 f = f 3
add1 x = x + 1

main = do
    print (show(pass3 add1))

--3
compose f g x = f(g x)

add1 x = x + 1
mult2 x = 2 * x 

main = do
    print (show (compose add1 mult2 10))

--4
addVal val = val + val

main = do
    putStr "Enter number: "
    s1 <- getLine
    let num = read s1 
    print (show(addVal num))

--5
isEven e = if  a % 2 == 0
                then "True"
            else if a % 2 == 1
                then "False"

main = do
    putStr "Enter number: "
    s1 <- getLine
    let num = read s1 
    print (show(isEven num))

--6
biggestOf3 a b c =
    if a > b
         then if a > 3
             then return a
    else if a < b
        then if b > c 
            then return b
    else 
        return c


main = do
    putStr "Enter number one: "
    s1 <- getLine
    let num1 = read s1
    putStr "Enter number two: "
    s2 <- getLine
    let num2 = read s2
    putStr "Enter number three: "
    s3 <- getLine
    let num3 = read s3
    print (show(biggestOf3 num1 num2 num3))

--7
add1 a = a +1
remove1 r = r 1

main = do
    putStr "Enter number: "
    s1 <- getLine
    let num = read s1
    print (show(add1 remove1 num))
-}

