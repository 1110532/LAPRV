﻿
// File generated by Wsutil Compiler version 1.0092 
#include <WebServices.h>
#include "schema.xsd.h"

typedef struct _schema_xsdLocalDefinitions 
{
    struct  // global types
    {
        char unused;
        struct // ArrayOfNo
        {
            struct // No
            {
                WS_FIELD_DESCRIPTION id;
                WS_FIELD_DESCRIPTION numNo;
                WS_FIELD_DESCRIPTION x;
                WS_FIELD_DESCRIPTION y;
                WS_FIELD_DESCRIPTION* NoFields [4]; 
            } Nodescs; // end of No
            WS_FIELD_DESCRIPTION No;
            WS_FIELD_DESCRIPTION* ArrayOfNoFields [1]; 
        } ArrayOfNodescs; // end of ArrayOfNo
    } globalTypes;  // end of global types
    struct // XML dictionary
    {
        struct // XML string list
        {
            WS_XML_STRING ArrayOfNoTypeName;  // ArrayOfNo
            WS_XML_STRING ArrayOfNoTypeNamespace;  // http://schemas.datacontract.org/2004/07/
            WS_XML_STRING NoTypeName;  // No
            WS_XML_STRING NoidLocalName;  // id
            WS_XML_STRING NonumNoLocalName;  // numNo
            WS_XML_STRING NoxLocalName;  // x
            WS_XML_STRING NoyLocalName;  // y
        } xmlStrings; // end of XML string list
        WS_XML_DICTIONARY dict;  
    } dictionary;  // end of XML dictionary
} _schema_xsdLocalDefinitions;

const static _schema_xsdLocalDefinitions schema_xsdLocalDefinitions =
{
    { // global types
        0,
        {   // ArrayOfNo
            {   // No
                { // field description for id
                WS_ELEMENT_FIELD_MAPPING,
                (WS_XML_STRING*)&schema_xsdLocalDefinitions.dictionary.xmlStrings.NoidLocalName, // id
                (WS_XML_STRING*)&schema_xsdLocalDefinitions.dictionary.xmlStrings.ArrayOfNoTypeNamespace, // http://schemas.datacontract.org/2004/07/
                WS_INT32_TYPE,
                0,
                WsOffsetOf(No, id),
                 WS_FIELD_OPTIONAL,
                0,
                0xffffffff
                },    // end of field description for id
                { // field description for numNo
                WS_ELEMENT_FIELD_MAPPING,
                (WS_XML_STRING*)&schema_xsdLocalDefinitions.dictionary.xmlStrings.NonumNoLocalName, // numNo
                (WS_XML_STRING*)&schema_xsdLocalDefinitions.dictionary.xmlStrings.ArrayOfNoTypeNamespace, // http://schemas.datacontract.org/2004/07/
                WS_INT32_TYPE,
                0,
                WsOffsetOf(No, numNo),
                 WS_FIELD_OPTIONAL,
                0,
                0xffffffff
                },    // end of field description for numNo
                { // field description for x
                WS_ELEMENT_FIELD_MAPPING,
                (WS_XML_STRING*)&schema_xsdLocalDefinitions.dictionary.xmlStrings.NoxLocalName, // x
                (WS_XML_STRING*)&schema_xsdLocalDefinitions.dictionary.xmlStrings.ArrayOfNoTypeNamespace, // http://schemas.datacontract.org/2004/07/
                WS_INT32_TYPE,
                0,
                WsOffsetOf(No, x),
                 WS_FIELD_OPTIONAL,
                0,
                0xffffffff
                },    // end of field description for x
                { // field description for y
                WS_ELEMENT_FIELD_MAPPING,
                (WS_XML_STRING*)&schema_xsdLocalDefinitions.dictionary.xmlStrings.NoyLocalName, // y
                (WS_XML_STRING*)&schema_xsdLocalDefinitions.dictionary.xmlStrings.ArrayOfNoTypeNamespace, // http://schemas.datacontract.org/2004/07/
                WS_INT32_TYPE,
                0,
                WsOffsetOf(No, y),
                 WS_FIELD_OPTIONAL,
                0,
                0xffffffff
                },    // end of field description for y
                {    // fields description for No
                (WS_FIELD_DESCRIPTION*)&schema_xsdLocalDefinitions.globalTypes.ArrayOfNodescs.Nodescs.id,
                (WS_FIELD_DESCRIPTION*)&schema_xsdLocalDefinitions.globalTypes.ArrayOfNodescs.Nodescs.numNo,
                (WS_FIELD_DESCRIPTION*)&schema_xsdLocalDefinitions.globalTypes.ArrayOfNodescs.Nodescs.x,
                (WS_FIELD_DESCRIPTION*)&schema_xsdLocalDefinitions.globalTypes.ArrayOfNodescs.Nodescs.y,
                },
            },    // No
            { // field description for No
            WS_REPEATING_ELEMENT_FIELD_MAPPING,
            0,
            0,
            WS_STRUCT_TYPE,
            (void*)&schema_xsd.globalTypes.No,
            WsOffsetOf(ArrayOfNo, No),
            WS_FIELD_POINTER| WS_FIELD_NILLABLE_ITEM,
            0,
            WsOffsetOf(ArrayOfNo, NoCount),
            (WS_XML_STRING*)&schema_xsdLocalDefinitions.dictionary.xmlStrings.NoTypeName, // No
            (WS_XML_STRING*)&schema_xsdLocalDefinitions.dictionary.xmlStrings.ArrayOfNoTypeNamespace, // http://schemas.datacontract.org/2004/07/
            0,
            },    // end of field description for No
            {    // fields description for ArrayOfNo
            (WS_FIELD_DESCRIPTION*)&schema_xsdLocalDefinitions.globalTypes.ArrayOfNodescs.No,
            },
        },    // ArrayOfNo
    }, // end of global types
    {    // dictionary 
        { // xmlStrings
            WS_XML_STRING_DICTIONARY_VALUE("ArrayOfNo",&schema_xsdLocalDefinitions.dictionary.dict, 0),
            WS_XML_STRING_DICTIONARY_VALUE("http://schemas.datacontract.org/2004/07/",&schema_xsdLocalDefinitions.dictionary.dict, 1),
            WS_XML_STRING_DICTIONARY_VALUE("No",&schema_xsdLocalDefinitions.dictionary.dict, 2),
            WS_XML_STRING_DICTIONARY_VALUE("id",&schema_xsdLocalDefinitions.dictionary.dict, 3),
            WS_XML_STRING_DICTIONARY_VALUE("numNo",&schema_xsdLocalDefinitions.dictionary.dict, 4),
            WS_XML_STRING_DICTIONARY_VALUE("x",&schema_xsdLocalDefinitions.dictionary.dict, 5),
            WS_XML_STRING_DICTIONARY_VALUE("y",&schema_xsdLocalDefinitions.dictionary.dict, 6),
        },  // end of xmlStrings
        
        {   // schema_xsddictionary
        // c0f3ac2f-e3d9-4280-8678-eb99d5847451 
        { 0xc0f3ac2f, 0xe3d9, 0x4280, { 0x86, 0x78, 0xeb,0x99, 0xd5, 0x84, 0x74, 0x51 } },
        (WS_XML_STRING*)&schema_xsdLocalDefinitions.dictionary.xmlStrings,
        7,
        TRUE,
        },
    },   //  end of dictionary
}; //  end of schema_xsdLocalDefinitions

const _schema_xsd schema_xsd =
{
    {// globalTypes
        {
        sizeof(ArrayOfNo),
        __alignof(ArrayOfNo),
        (WS_FIELD_DESCRIPTION**)&schema_xsdLocalDefinitions.globalTypes.ArrayOfNodescs.ArrayOfNoFields,
        WsCountOf(schema_xsdLocalDefinitions.globalTypes.ArrayOfNodescs.ArrayOfNoFields),
        (WS_XML_STRING*)&schema_xsdLocalDefinitions.dictionary.xmlStrings.ArrayOfNoTypeName, // ArrayOfNo
        (WS_XML_STRING*)&schema_xsdLocalDefinitions.dictionary.xmlStrings.ArrayOfNoTypeNamespace, // http://schemas.datacontract.org/2004/07/
        0,
        0,
        0,
        },   // end of struct description for ArrayOfNo
        {
        sizeof(No),
        __alignof(No),
        (WS_FIELD_DESCRIPTION**)&schema_xsdLocalDefinitions.globalTypes.ArrayOfNodescs.Nodescs.NoFields,
        WsCountOf(schema_xsdLocalDefinitions.globalTypes.ArrayOfNodescs.Nodescs.NoFields),
        (WS_XML_STRING*)&schema_xsdLocalDefinitions.dictionary.xmlStrings.NoTypeName, // No
        (WS_XML_STRING*)&schema_xsdLocalDefinitions.dictionary.xmlStrings.ArrayOfNoTypeNamespace, // http://schemas.datacontract.org/2004/07/
        0,
        0,
        0,
        },   // end of struct description for No
    }, // globalTypes
    {// globalElements
        {
            (WS_XML_STRING*)&schema_xsdLocalDefinitions.dictionary.xmlStrings.ArrayOfNoTypeName, // ArrayOfNo
            (WS_XML_STRING*)&schema_xsdLocalDefinitions.dictionary.xmlStrings.ArrayOfNoTypeNamespace, // http://schemas.datacontract.org/2004/07/
            WS_STRUCT_TYPE,
            (void*)&schema_xsd.globalTypes.ArrayOfNo,
        },
        {
            (WS_XML_STRING*)&schema_xsdLocalDefinitions.dictionary.xmlStrings.NoTypeName, // No
            (WS_XML_STRING*)&schema_xsdLocalDefinitions.dictionary.xmlStrings.ArrayOfNoTypeNamespace, // http://schemas.datacontract.org/2004/07/
            WS_STRUCT_TYPE,
            (void*)&schema_xsd.globalTypes.No,
        },
    }, // globalElements
}; // end of _schema_xsd
