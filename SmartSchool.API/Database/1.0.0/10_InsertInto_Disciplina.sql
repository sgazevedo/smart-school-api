INSERT INTO Disciplina (Nome,CargaHoraria,prerequisitoid,professorid,cursoid) 
VALUES
	 ('Matemática',0,NULL,1,(SELECT ID FROM CURSO WHERE NOME = 'Tecnologia da Informação')),
	 ('Matemática',0,NULL,1,(SELECT ID FROM CURSO WHERE NOME = 'Ciência da Computação')),
	 ('Física',0,2,2,(SELECT ID FROM CURSO WHERE NOME = 'Ciência da Computação')),
	 ('Português',0,NULL,3,(SELECT ID FROM CURSO WHERE NOME = 'Tecnologia da Informação')),
	 ('Inglês',0,NULL,4,(SELECT ID FROM CURSO WHERE NOME = 'Tecnologia da Informação')),
	 ('Inglês',0,NULL,4,(SELECT ID FROM CURSO WHERE NOME = 'Sistemas de Informação')),
	 ('Inglês',0,NULL,4,(SELECT ID FROM CURSO WHERE NOME = 'Ciência da Computação')),
	 ('Programação',0,NULL,5,(SELECT ID FROM CURSO WHERE NOME = 'Tecnologia da Informação')),
	 ('Programação',0,NULL,5,(SELECT ID FROM CURSO WHERE NOME = 'Sistemas de Informação')),
	 ('Programação',0,NULL,5,(SELECT ID FROM CURSO WHERE NOME = 'Ciência da Computação'));
