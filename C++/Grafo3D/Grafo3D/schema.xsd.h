﻿
// File generated by Wsutil Compiler version 1.0092 
// This file defines C/C++ functions, callbacks, types that correspond to operations,
// and types specified in WSDL and XSD files processed by WsUtil compiler. The generated 
// type definitions, function and callback declarations can be used with various 
// Web Services APIs either in applications that send and receive requests to and 
// from a running web service, or in the implementation of web services, or in both. 
//
// If Wsutil has generated this file from an XSD file, the file contains definition of 
// C/C++ structures types that correspond to types defined in the XSD file. 
// For example, if the following XSD complexType is defined in the XSD file
//
//      <xsd:complexType name="AddRequest">
//          <xsd:sequence>
//              <xsd:element minOccurs="0" name="a" type="xsd:int" />
//              <xsd:element minOccurs="0" name="b" type="xsd:int" />
//          </xsd:sequence>
//      </xsd:complexType>
// 
// this file contains the following definitions of the structure 
//      // AddRequest (xsd:complexType)
//      // <AddRequest xmlns='http://tempuri.org'>
//      // WS_STRUCT_DESCRIPTION* = &calculator_xsd.globalTypes.AddRequest
//      struct AddRequest
//      {
//          int a;
//          int b;
//      };
//
// For more information on how to use the C/C++ types generated in this file to read or write elements of XML documents that conform to 
// this XSD, please see the documentation for 
// WsReadType() and WsWriteType() functions.
// 
#if _MSC_VER > 1000 
#pragma once
#endif

#ifdef __cplusplus
extern "C" {
#endif

// The following types were generated:

//     struct ArrayOfNoBD;
//     struct NoBD;
//     struct ArrayOfArcoBD;
//     struct ArcoBD;
//     struct Utilizador;
//     struct Ligacao;
//     struct ArrayOfNoBD;
//     struct NoBD;
//     struct ArrayOfArcoBD;
//     struct ArcoBD;
//     struct Utilizador;
//     struct Ligacao;

// The following header files must be included in this order before this one

// #include <WebServices.h>
// #include "schemas.microsoft.com.2003.10.Serialization.Arrays.xsd.h"

////////////////////////////////////////////////
// C structure definitions for generated types
////////////////////////////////////////////////

// typeDescription: schema_xsd.globalTypes.ArrayOfNoBD
typedef struct ArrayOfNoBD 
{
    unsigned int NoBDCount;
    __field_ecount(NoBDCount)struct NoBD** NoBD; // optional
} ArrayOfNoBD;

// typeDescription: schema_xsd.globalTypes.NoBD
typedef struct NoBD 
{
    WCHAR* avatar3d; // optional
    WCHAR* humor; // optional
    int id;
    WCHAR* nome; // optional
    int ntag;
    int x;
    int y;
} NoBD;

// typeDescription: schema_xsd.globalTypes.ArrayOfArcoBD
typedef struct ArrayOfArcoBD 
{
    unsigned int ArcoBDCount;
    __field_ecount(ArcoBDCount)struct ArcoBD** ArcoBD; // optional
} ArrayOfArcoBD;

// typeDescription: schema_xsd.globalTypes.ArcoBD
typedef struct ArcoBD 
{
    int forca;
    int idPrim;
    int idRel;
    int idSec;
} ArcoBD;

// typeDescription: schema_xsd.globalTypes.Utilizador
typedef struct Utilizador 
{
    WCHAR* avatar; // optional
    WCHAR* morada; // optional
    WCHAR* nasc; // optional
    WCHAR* nick; // optional
    WCHAR* nome; // optional
    int tele;
} Utilizador;

// typeDescription: schema_xsd.globalTypes.Ligacao
typedef struct Ligacao 
{
    int id1;
    int id2;
    unsigned int tagsCount;
    __field_ecount_opt(tagsCount)WCHAR** tags; // optional
} Ligacao;

////////////////////////////////////////////////
// Global web service descriptions.
////////////////////////////////////////////////

typedef struct _schema_xsd
{
    struct // globalTypes
    {
        // xml type: ArrayOfNoBD ("http://schemas.datacontract.org/2004/07/")
        // c type: ArrayOfNoBD
        // WS_TYPE: WS_STRUCT_TYPE
        // typeDescription: schema_xsd.globalTypes.ArrayOfNoBD
        WS_STRUCT_DESCRIPTION ArrayOfNoBD;
        
        // xml type: NoBD ("http://schemas.datacontract.org/2004/07/")
        // c type: NoBD
        // WS_TYPE: WS_STRUCT_TYPE
        // typeDescription: schema_xsd.globalTypes.NoBD
        WS_STRUCT_DESCRIPTION NoBD;
        
        // xml type: ArrayOfArcoBD ("http://schemas.datacontract.org/2004/07/")
        // c type: ArrayOfArcoBD
        // WS_TYPE: WS_STRUCT_TYPE
        // typeDescription: schema_xsd.globalTypes.ArrayOfArcoBD
        WS_STRUCT_DESCRIPTION ArrayOfArcoBD;
        
        // xml type: ArcoBD ("http://schemas.datacontract.org/2004/07/")
        // c type: ArcoBD
        // WS_TYPE: WS_STRUCT_TYPE
        // typeDescription: schema_xsd.globalTypes.ArcoBD
        WS_STRUCT_DESCRIPTION ArcoBD;
        
        // xml type: Utilizador ("http://schemas.datacontract.org/2004/07/")
        // c type: Utilizador
        // WS_TYPE: WS_STRUCT_TYPE
        // typeDescription: schema_xsd.globalTypes.Utilizador
        WS_STRUCT_DESCRIPTION Utilizador;
        
        // xml type: Ligacao ("http://schemas.datacontract.org/2004/07/")
        // c type: Ligacao
        // WS_TYPE: WS_STRUCT_TYPE
        // typeDescription: schema_xsd.globalTypes.Ligacao
        WS_STRUCT_DESCRIPTION Ligacao;
        
    } globalTypes;
    struct // globalElements
    {
        // xml element: ArrayOfNoBD ("http://schemas.datacontract.org/2004/07/")
        // c type: ArrayOfNoBD
        // elementDescription: schema_xsd.globalElements.ArrayOfNoBD
        WS_ELEMENT_DESCRIPTION ArrayOfNoBD;
        
        // xml element: NoBD ("http://schemas.datacontract.org/2004/07/")
        // c type: NoBD
        // elementDescription: schema_xsd.globalElements.NoBD
        WS_ELEMENT_DESCRIPTION NoBD;
        
        // xml element: ArrayOfArcoBD ("http://schemas.datacontract.org/2004/07/")
        // c type: ArrayOfArcoBD
        // elementDescription: schema_xsd.globalElements.ArrayOfArcoBD
        WS_ELEMENT_DESCRIPTION ArrayOfArcoBD;
        
        // xml element: ArcoBD ("http://schemas.datacontract.org/2004/07/")
        // c type: ArcoBD
        // elementDescription: schema_xsd.globalElements.ArcoBD
        WS_ELEMENT_DESCRIPTION ArcoBD;
        
        // xml element: Utilizador ("http://schemas.datacontract.org/2004/07/")
        // c type: Utilizador
        // elementDescription: schema_xsd.globalElements.Utilizador
        WS_ELEMENT_DESCRIPTION Utilizador;
        
        // xml element: Ligacao ("http://schemas.datacontract.org/2004/07/")
        // c type: Ligacao
        // elementDescription: schema_xsd.globalElements.Ligacao
        WS_ELEMENT_DESCRIPTION Ligacao;
        
    } globalElements;
} _schema_xsd;

extern const _schema_xsd schema_xsd;

#ifdef __cplusplus
}
#endif

