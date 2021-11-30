path = "text.txt"

main = do
    file <- readFile path
    putStrLn file