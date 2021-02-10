mother('Lilya', 'Oleg').
mother('Lilya', 'Ignat').
mother('Kira', 'Olena').
mother('Olena', 'Viktor').
mother('Olena', 'Vika').
mother('Masha', 'Makar').
mother('Zuhra', 'Nadia').

father('Mykola', 'Oleg').
father('Mykola', 'Ignat').
father('Oleg', 'Viktor').
father('Makar', 'Olena').
father('Oleg', 'Vika').
father('Danylo', 'Makar').
father('Ignat', 'Nadia').
father('Ahmed', 'Zuhra').

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

grandmother(X, Y):-mother(X, Z), (mother(Z, Y); father(Z, Y)).
grandfather(X, Y):-father(X, Z), (mother(Z, Y); father(Z, Y)).

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
aunt(Y, X):-((grandmother(Z, X), mother(Z, Y));(grandfather(Z, X), father(Z, Y))), not(mother(Y, X)), not(father(Y, X)).
cousin(X, Y):-aunt(Z, X), (mother(Z, Y); father(Z, Y)).
%?-father(_,'Oleg').