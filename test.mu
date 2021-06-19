n = 9;
log "Print Odd and Even";
while n > 0 {

  # expressions can be surrounded by parenthesis, of course
  if (n % 2 == 0) {
    log n + " -> even";
  }
  else {
    log n + " -> odd";
  }
  a=2;
  b=2;
  c= a+b;
  log "sum pf a and b " + c;
  n = n - 1;
}