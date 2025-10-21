#  Introducción a la programación de juegos 2D. UI-Eventos

En los ejercicios de esta práctica se ha trabajado con eventos y con la interfaz de usuario, enfocándose en el funcionamiento de un proyectil en la escena y tratando de obtener en todos los casos los resultados esperados expuestos en los enunciados.

## Ejercicio 1: Sprite simple y visibilidad

Para este primer ejercicio, se ha colocado un sprite en la escena que actúe como proyectil y, con un script, se ha usado `SpriteRenderer.enabled` para ocultarlo al ejecutar el juego. En dicho script, también se ha incluido una función que activa la visibilidad del proyectil, de forma que se ha añadido a un botón dentro del Canvas de la UI para que funcione correctamente.

<img width="595" height="140" alt="img1" src="https://github.com/user-attachments/assets/9da2ffa4-6d1e-4581-83fb-6d34ad5050e5" />

Al hacer esto y ejecutar el juego, obtenemos el siguiente resultado:

![gif1](https://github.com/user-attachments/assets/7b02f87b-e862-4872-b9c9-8d6a79eaaaff)

## Ejercicio 2: Añadir animación simple al proyectil

Para crear una animación de desplazamiento simple al proyectil, se ha seleccionado el sprite y se ha abierto en la ventana de animación de Unity. Aquí, se ha creado una animación que desplaza la posición del proyectil hacia la izquierda en el plano usado transform.

<img width="1918" height="1078" alt="img2" src="https://github.com/user-attachments/assets/3741dc92-2c60-4b8e-a65f-6c02b13120f0" />

Luego, en el animator que se ha creado, se ha añadido una animación de idle para indicar que este no se dispare al entrar al juego. De esta animación, se añade una transición a la de disparo del proyectil pero solo si se cumple la condición de disparo a la que se hace referencia en el script de control.

<img width="1593" height="493" alt="img3" src="https://github.com/user-attachments/assets/a9b12315-88a1-4627-bcaa-2032704f4dcd" />

En dicho script de control, se encuentra una función de disparo del proyectil que hace que se renderice en la imagen y se reproduzca la animación. Dicha función se añade a un botón creado en la UI para que, al pulsarlo, se cree esta secuencia mencionada en la escena

<img width="593" height="126" alt="img4" src="https://github.com/user-attachments/assets/994bf3b8-24e8-45cd-a8ac-bde59f11ad08" />

Al realizar estos pasos y pulsar el botón de disparo dentro de la ejecución, se obtiene este efecto:

![gif2](https://github.com/user-attachments/assets/4f7b1bef-cb61-4623-b931-e5730a674541)

## Ejercicio 3: Proyectil como hijo del jugador

Para realizar el tercer ejercicio, lo único que se ha hecho es añadir el sprite de proyectil dentro del jugador en la jerarquía de objetos de la escena, de forma que este se desplace junto con el sprite del jugador

<img width="326" height="45" alt="img5" src="https://github.com/user-attachments/assets/391ac75c-51d5-4950-9f23-24222afaaf35" />

No se apreció ningún error durante la realización del ejercicio, el script aplicado funcionó correctamente. 
Al probarlo, este es el resultado que se obtiene:

![gif3](https://github.com/user-attachments/assets/362ccf56-8f1a-4459-8179-fe5a3321627b)

## Ejercicio 4: Ocultamiento automático

Para ocultar el proyectil según se acaba la animación de disparo, se creó un script con una variable que indicaba el tiempo de finalización de la animación (0.9 segundos). Para llevar esto a cabo, se usa la corrutina de `IEnumerator` con `yield return` para pausar la animación en el tiempo establecido en la variable.

<img width="592" height="85" alt="img6" src="https://github.com/user-attachments/assets/f34c5d31-ca98-4d91-85e5-85b3580498e8" />

Así, se logra el siguiente efecto:

![gif4](https://github.com/user-attachments/assets/13692ff3-5810-4212-b6f0-4a787714ace1)

## Ejercicio 5: Prefab e instanciación del proyectil

Para realizar este ejercicio, primero se crea un prefab del proyectil en escena arrastrándolo desde la jerarquía de objetos hasta el content drawer.

<img width="1118" height="653" alt="img7" src="https://github.com/user-attachments/assets/e7c9c16b-c21a-455a-b3fc-876fb1507bba" />

Luego, se añade un gameobject vacío como hijo del player que actuará como disparados de los proyectiles. Dicho disparador llevará un script que permitirá renderizar clones del prefab al disparar en la escena. En cuanto a su funcionamiento, cuenta con dos variables que hacen referencia al prefab del proyectil para recuperar sus propiedades y a la posición del gameobject vacío del jugador para saber desde dónde debe disparar.

<img width="601" height="117" alt="img8" src="https://github.com/user-attachments/assets/89c27fa8-35c9-4b2f-b049-a61fcc7e9d4d" />

El resultado alcanzado finalmente es el siguiente:

![gif5](https://github.com/user-attachments/assets/761e63a9-186a-48f9-ba81-ba38403e084d)

## Ejercicio 6: Colisión con objeto para disparar

En la realización de este ejercicio, se ha añadido un objeto con una caja de colisión con "is trigger" en la escena que, al colisionar con el jugador, activa el proyectil y su animación de disparo. Para que el jugador detectase que el objeto en concreto con el que había colisionado era dicha zona, se le añadió una etiqueta de reconocimiento a la que se hace referencia en el script de disparo.

<img width="600" height="72" alt="img9" src="https://github.com/user-attachments/assets/afb1858b-705e-4a2f-b947-6d6fab7715bc" />

Así, nos queda el siguiente resultado:

![gif6](https://github.com/user-attachments/assets/e591fb41-b5f4-4877-a664-3c1fb2b06c1f)

## Ejercicio 7: UI con velocidad Turbo/Normal.

Para realizar esta última tarea, se creó un toggle dentro de la UI cuyo label indicase si el modo turbo está activado o no.

<img width="287" height="92" alt="img10" src="https://github.com/user-attachments/assets/b8a1fae5-5f02-4610-8c58-a2a68e9a917b" />

Dentro del script de cambio de velocidad, se crea una función que cambia según la condición de que este toggle esté marcado o no, por lo que se añade desde el inspector.

<img width="593" height="130" alt="img11" src="https://github.com/user-attachments/assets/92144c5e-acf6-4db7-9f93-740737fcb9b1" />

Así queda el resultado final:

![gif7](https://github.com/user-attachments/assets/ff212e94-9f5c-44ab-8ba0-e443462fb948)







