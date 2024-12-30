## 1.1 Design patterns ou patterns de conception

- Schéma d'objets qui forme une solution a un problème connu et fréquent
- Ensemble de classes et de relation
- Dans le cadre de la POO
- Bases sur les bonnes pratiques
- Schéma en UML
- Pour gérer les relations entre les classes : des interfaces

## 1.2 La description des patterns de conception

- le langage UML et le C# 
- Pour chaque pattern
	- Nom
	- Description
	- Description sous forme UML
	- Structure générique du pattern
	- Le cas d'utilisation
	- Un exemple de code en C#

# CHAPITRE 2 - Une étude de cas : la vente en ligne de véhicules

## 2.2 Cahier des charges

- Véhicules destinés à la vente
- Catalogues
- Options
- Panier / gestion des commandes

# CHAPITRE 3 - Introduction aux patterns de construction

Abstraire les mécanismes de création d'objets

## 3.2.2 Les solutions proposées par les patterns de construction

En C#, une instruction de création d'une instance de classe :

```csharp
var object = new MyClass()
```

Dans certains cas il est nécessaire de paramétrer la construction d'objets :

```csharp
public class Document
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }
    public DateTime Created { get; set; }
}

public class Program {
    public Document CreateDoc(string typeDoc)
    {
        Document doc = null;

        if (typeDoc == "Word")
        {
            doc = new Document();
            doc.Title = "New Document";
            doc.Content = "Content";
        }
        else if (typeDoc == "Excel")
        {
            doc = new Document();
            doc.Title = "New Excel Document";
            doc.Content = "Excel Content";
        }
        else
        {
            doc = new Document();
            doc.Title = "New Document";
            doc.Content = "Content";
        }
    }
}
```

# Chapitre 4 - Le pattern Abstract Factory

## 4.1. Description

- Le but du pattern est la création d'objets regroupés en familles sans devoir connaitre les classes concrètes destinées à la création de ces objets.
- Signature de méthode : ```public void Document()```
- Corps de la méthode : ```{ //ce qu'on trouve écris dans la méthode } ```

# Chapitre 5 - Le pattern Builder

## 5.1. Description

- Composition : mécanisme qui permet à une classe de contenir une instance de cette même classe ou d'une autre

# Chapitre 7 - Le pattern prototype

## 7.1. Description

- Création de nouveaux objets par duplication d'objets existants 
- On les appelle Prototype
- Capacité de clonage

# Chapitre 8 - Le pattern Sigleton

## 8.1. Description

- Le pattern Singleton permet d'assurer qu'une classe ne possède qu'une seule instance au cours de l'exécution du programme

- Une méthode de classe unique qui retourne cette instance