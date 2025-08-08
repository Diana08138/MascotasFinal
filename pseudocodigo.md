INICIO
  //defini la Mascota
    ATRIBUTOS PRIVADOS:
      nombre string
      edad int
      tipo string
      sonido string

    //inician los atributos
       nombre = nom
       edad = ed
       tipo = ti
       sonido = son

    // Getter para edad getEdad()
      RETORNAR edad

    // Setter para setEdad(nuevaEdad)
       asignar edad = nuevaEdad

    METODO MostrarInformacion()
      ESCRIBIR "Nombre: " + nombre
      ESCRIBIR "Edad: " + edad + " años"
      ESCRIBIR "Tipo: " + tipo

      // Metodo para emitir el sonido

    METODO para EmitirSonido()
      ESCRIBIR nombre + " hace: " + sonido

      // Metodo para calcular la edad humana

    METODO para CalcularEdadHumana()
      DEFINIR factorConversion (entero)
      factorConversion = 0
      
      // Se usa un bucle (switch) para determinar el factor de conversion

      SEGUN tipo 
        CASO "perro":
          factorConversion = 7
        CASO "gato":
          factorConversion = 4
        CASO "hamster":
          factorConversion = 25
        CASO CONTRARIO:
          ESCRIBIR "Mascota no reconocida. Se usara el factor 7 por defecto."
          factorConversion = 7
      
      RETORNAR edad * factorConversion

  DEFINIR CLASE Programa
    METODO PRINCIPAL Main()
      // Para que el usuario seleccione la mascota deseada
      CREAR Mascota oreo CON nombre="Oreo", edad=6, tipo="perro", sonido="guau guau "
      CREAR Mascota copo CON nombre="Copo", edad=9, tipo="gato", sonido="miau"
      CREAR Mascota wallas CON nombre="Wallas", edad=2, tipo="hamster", sonido="suic"

      // Mostrar menu de opciones al usuario
      ESCRIBIR "Seleccione una mascota para saber su informacion:"
      ESCRIBIR "1. Oreo (perro)"
      ESCRIBIR "2. Copo (gato)"
      ESCRIBIR "3. Wallas (hamster)"
      ESCIRBIR "Ingrese la opcion valida: "

      // Leer la opcion del usuario
      LEER opcion 
      
      ESCRIBIR "--------------------"

      // Procesa la opcion seleccionada
      SEGUN opcion
        CASO "1":
          ESCIRBIR "La informacion de Oreo es la siguiente: "
          LLAMAR oreo.MostrarInformacion()
          LLAMAR oreo.EmitirSonido()
          ESCRIBIR edadHumanaOreo (entero)
          edadHumanaOreo = LLAMAR oreo.CalcularEdadHumana()
          ESCRIBIR "Oreo en edad humana tiene " + edadHumanaOreo + " años."
        CASO "2":
          ESCRIBIR "La informacion de Copo es la siguiente: "
          LLAMAR copo.MostrarInformacion()
          LLAMAR copo.EmitirSonido()
          ESCRBIR edadHumanaCopo (entero)
          edadHumanaCopo = LLAMAR copo.CalcularEdadHumana()
          ESCRIBIR "Copo en edad humana tiene " + edadHumanaCopo + " años."
        CASO "3":
          ESCRIBIR "La informacion de Wallas es la siguiente: "
          LLAMAR wallas.MostrarInformacion()
          LLAMAR wallas.EmitirSonido()
          DEFINIR edadHumanaWallas (entero)
          edadHumanaWallas = LLAMAR wallas.CalcularEdadHumana()
          ESCRIBIR "Wallas en edad humana tiene " + edadHumanaWallas + " años humanos."
        CASO CONTRARIO:
          ESCIRBIR "La opcion es invalida. Ingrese nuevamente una opcion del 1 al 3."

FIN 