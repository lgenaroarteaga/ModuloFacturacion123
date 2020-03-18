# Modulo Facturación

Modulo facturación - SOE UAGRM - Arquitectura de software

## Requisitos
Para poder ejecutar el proyecto se necesita: 
	
  
  * Visual Studio 2017
  
  
  * SQL server 2017
  
## Descargar las fuentes
Puede descargar el proyecto desde: 


https://github.com/lgenaroarteaga/ModuloFacturacion/archive/master.zip

## Módulos desarrollados
En el presente proyecto se ha desarrollado el módulo de Facturación.
### Módulo de facturación
Para probar el funcionamiento debe ejecutar el aplicativo
## Aplicación del Patrón Value Object
### Models/ValueObject
ValueObject.cs                          
    └ DecimalNonNegative.cs               
    └ NumericNonNegative.cs         
    └ NumericString.cs              
    └ StringNotNull.cs              


## Aplicación del Patrón Agregate Root
### Models/Entities
IAgregateRoot.cs                    
    └ Invoice.cs                     
    └ Authorization.cs               
