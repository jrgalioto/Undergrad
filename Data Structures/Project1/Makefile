CFLAGS = -c -I. -I$(HOME)/Programming/include
LFLAGS = -L. -L$(HOME)/Programming/lib
LIBS = -ldataStructures

project1: project1.o fraction.o
	g++ $(LFLAGS) -o project1 project1.o fraction.o $(LIBS)

project1.o: project1.cc fraction.h
	g++ $(CFLAGS) project1.cc

fraction.o: fraction.cc fraction.h
	g++ $(CFLAGS) fraction.cc
