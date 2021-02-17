mother('Lilya', 'Oleg').
mother('Kira', 'Olena').
mother('Olena', 'Viktor').
mother('Olena', 'Vika').

father('Mykola', 'Oleg').
father('Oleg', 'Viktor').
father('Makar', 'Olena').
father('Oleg', 'Vika').

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

grandmother(X, Y):-mother(X, Z), (mother(Z, Y); father(Z, Y)).
grandfather(X, Y):-father(X, Z), (mother(Z, Y); father(Z, Y)).

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
