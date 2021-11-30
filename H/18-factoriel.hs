findFactorial n initialValue index =
    if index > n
        then initialValue
    else findFactorial n (initialValue * index) (index + 1)

factorial n = findFactorial n 1 1