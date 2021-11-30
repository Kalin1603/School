{-
--1
main = do
    putStr "Enter your First Name: "
    firstName <- getLine 
    putStr "Enter your Second Name: "
    secondName <- getLine 
    putStrLn (firstName ++ " " ++ secondName)

--2
main = do
    putStr "Enter your First number: "
    firstNum <- getLine 
    putStr "Enter your Second number: "
    secondNum <- getLine
    let num1 = read firstNum :: Int
    let num2 = read secondNum :: Int
    let result = num1 * num2
    print (show result)

--3
import Text.Printf

main = do
    s1 <- getLine 
    let r = read s1 :: Double 
    let result = pi * r * r
    printf "%.4g" result
-}
