#  Introducción a la programación de juegos 2D. UI-Eventos

En los ejercicios de esta práctica se ha trabajado con eventos y con la interfaz de usuario, enfocándose en el funcionamiento de un proyectil en la escena y tratando de obtener en todos los casos los resultados esperados expuestos en los enunciados.

## Ejercicio 1: Sprite simple y visibilidad

Para este primer ejercicio, se ha colocado un sprite en la escena que actúe como proyectil y, con un script, se ha usado `SpriteRenderer.enabled` para ocultarlo al ejecutar el juego. En dicho script, también se ha incluido una función que activa la visibilidad del proyectil, de forma que se ha añadido a un botón dentro del Canvas de la UI para que funcione correctamente.

img1

Al hacer esto y ejecutar el juego, obtenemos el siguiente resultado:

gif1

## Ejercicio 2: Añadir animación simple al proyectil

Para crear una animación de desplazamiento simple al proyectil, se ha seleccionado el sprite y se ha abierto en la ventana de animación de Unity. Aquí, se ha creado una animación que desplaza la posición del proyectil hacia la izquierda en el plano usado transform.

img2 

Luego, en el animator que se ha creado, se ha añadido una animación de idle para indicar que este no se dispare al entrar al juego. De esta animación, se añade una transición a la de disparo del proyectil pero solo si se cumple la condición de disparo a la que se hace referencia en el script de control.

img3

En dicho script de control, se encuentra una función de disparo del proyectil que hace que se renderice en la imagen y se reproduzca la animación. Dicha función se añade a un botón creado en la UI para que, al pulsarlo, se cree esta secuencia mencionada en la escena

img4

Al realizar estos pasos y pulsar el botón de disparo dentro de la ejecución, se obtiene este efecto:

gif2

## Ejercicio 3: Proyectil como hijo del jugador

Para realizar el tercer ejercicio, lo único que se ha hecho es añadir el sprite de proyectil dentro del jugador en la jerarquía de objetos de la escena, de forma que este se desplace junto con el sprite del jugador

img5

No se apreció ningún error durante la realización del ejercicio, el script aplicado funcionó correctamente. 
Al probarlo, este es el resultado que se obtiene:

gif3

## Ejercicio 4: Ocultamiento automático

Para ocultar el proyectil según se acaba la animación de disparo, se creó un script con una variable que indicaba el tiempo de finalización de la animación (0.9 segundos). Para llevar esto a cabo, se usa la corrutina de `IEnumerator` con `yield return` para pausar la animación en el tiempo establecido en la variable.

img6

Así, se logra el siguiente efecto:

gif4

## Ejercicio 5: Prefab e instanciación del proyectil

Para realizar este ejercicio, primero se crea un prefab del proyectil en escena arrastrándolo desde la jerarquía de objetos hasta el content drawer.

img7

Luego, se añade un gameobject vacío como hijo del player que actuará como disparados de los proyectiles. Dicho disparador llevará un script que permitirá renderizar clones del prefab al disparar en la escena. En cuanto a su funcionamiento, cuenta con dos variables que hacen referencia al prefab del proyectil para recuperar sus propiedades y a la posición del gameobject vacío del jugador para saber desde dónde debe disparar.

img8

El resultado alcanzado finalmente es el siguiente:

gif5

## Ejercicio 6: Colisión con objeto para disparar

En la realización de este ejercicio, se ha añadido un objeto con una caja de colisión con "is trigger" en la escena que, al colisionar con el jugador, activa el proyectil y su animación de disparo. Para que el jugador detectase que el objeto en concreto con el que había colisionado era dicha zona, se le añadió una etiqueta de reconocimiento a la que se hace referencia en el script de disparo.

img9

Así, nos queda el siguiente resultado:

gif6

## Ejercicio 7: UI con velocidad Turbo/Normal.

Para realizar esta última tarea, se creó un toggle dentro de la UI cuyo label indicase si el modo turbo está activado o no.

img10

Dentro del script de cambio de velocidad, se crea una función que cambia según la condición de que este toggle esté marcado o no, por lo que se añade desde el inspector.

img11

Así queda el resultado final:

gif7






