/****************
Cria��o do datasource:
Control Panel > Administrative Tools > Data Sources (ODBC)
****************/

:- ensure_loaded( system(dblink) ). % carrega o PRODATA
:- dynamic datasource/1.
:- consult(bf).

init_bd_conn:-
	%db_connect( lapr, HDBC ),
	db_connect('Server=gandalf;Database=ARQSI22;User Id=ARQSI22;Password=rokbar159;',HDBC), % efectua liga��o ao datasource identificado por 'grafo'
	assert( datasource( HDBC ) ),
	%db_attach( cidade, 'cidades' ), % associa o predicado cidade � tabela cidades
	%db_attach( estrada, 'estradas' ), % associa o predicado estrada � tabela estradas
	db_flag( show_sql, _, off ). % n�o mostra as queries SQL geradas

end_bd_conn:-
	retract( datasource( HDBC ) ),
	db_disconnect( HDBC ).

/**************
?- init_bd_conn.
?- bf(+Orig, +Dest, -Perc, -Dist).
?- end_bd_conn.
***************/
