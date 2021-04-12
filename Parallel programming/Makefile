all: run

clean:
	rm -f src/*.class out/Miller.jar

Miller.jar: out/parcs.jar src/*.java
	@javac -cp out/parcs.jar src/*.java
	@jar cf out/Miller.jar -C src .
	@rm -f src/*.class

run: Miller.jar
	@cd out && java -cp 'parcs.jar:Miller.jar' Miller
