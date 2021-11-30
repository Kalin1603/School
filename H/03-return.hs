line :: IO String 
line = 
    return "Print some text"

main = do
    l <- line
    putStrLn l