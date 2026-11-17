REM Factorial Calculation (Label-Only BASIC)
PRINT "Factorial Calculator"
PRINT "Enter a positive number:"
INPUT n

fact = 1
i = 1

loop:
IF i > n THEN GOTO finish
fact = fact * i
i = i + 1
GOTO loop

finish:
PRINT "Factorial result is:"
PRINT fact
END
