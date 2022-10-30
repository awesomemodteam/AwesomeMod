﻿using System;
using System.Runtime.InteropServices;

// ReSharper disable FieldCanBeMadeReadOnly.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable NotAccessedField.Global
// ReSharper disable IdentifierTypo
// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global

namespace UnhollowerBaseLib.Runtime
{
    [Flags]
    public enum Il2CppMethodImplFlags : ushort
    {
        METHOD_IMPL_ATTRIBUTE_CODE_TYPE_MASK = 0x0003,
        METHOD_IMPL_ATTRIBUTE_IL = 0x0000,
        METHOD_IMPL_ATTRIBUTE_NATIVE = 0x0001,
        METHOD_IMPL_ATTRIBUTE_OPTIL = 0x0002,
        METHOD_IMPL_ATTRIBUTE_RUNTIME = 0x0003,

        METHOD_IMPL_ATTRIBUTE_MANAGED_MASK = 0x0004,
        METHOD_IMPL_ATTRIBUTE_UNMANAGED = 0x0004,
        METHOD_IMPL_ATTRIBUTE_MANAGED = 0x0000,

        METHOD_IMPL_ATTRIBUTE_FORWARD_REF = 0x0010,
        METHOD_IMPL_ATTRIBUTE_PRESERVE_SIG = 0x0080,
        METHOD_IMPL_ATTRIBUTE_INTERNAL_CALL = 0x1000,
        METHOD_IMPL_ATTRIBUTE_SYNCHRONIZED = 0x0020,
        METHOD_IMPL_ATTRIBUTE_NOINLINING = 0x0008,
        METHOD_IMPL_ATTRIBUTE_MAX_METHOD_IMPL_VAL = 0xffff,
    }

    [Flags]
    public enum Il2CppMethodFlags : ushort
    {
        METHOD_ATTRIBUTE_MEMBER_ACCESS_MASK = 0x0007,
        METHOD_ATTRIBUTE_COMPILER_CONTROLLED = 0x0000,
        METHOD_ATTRIBUTE_PRIVATE = 0x0001,
        METHOD_ATTRIBUTE_FAM_AND_astEM = 0x0002,
        METHOD_ATTRIBUTE_astEM = 0x0003,
        METHOD_ATTRIBUTE_FAMILY = 0x0004,
        METHOD_ATTRIBUTE_FAM_OR_astEM = 0x0005,
        METHOD_ATTRIBUTE_PUBLIC = 0x0006,

        METHOD_ATTRIBUTE_STATIC = 0x0010,
        METHOD_ATTRIBUTE_FINAL = 0x0020,
        METHOD_ATTRIBUTE_VIRTUAL = 0x0040,
        METHOD_ATTRIBUTE_HIDE_BY_SIG = 0x0080,

        METHOD_ATTRIBUTE_VTABLE_LAYOUT_MASK = 0x0100,
        METHOD_ATTRIBUTE_REUSE_SLOT = 0x0000,
        METHOD_ATTRIBUTE_NEW_SLOT = 0x0100,

        METHOD_ATTRIBUTE_STRICT = 0x0200,
        METHOD_ATTRIBUTE_ABSTRACT = 0x0400,
        METHOD_ATTRIBUTE_SPECIAL_NAME = 0x0800,

        METHOD_ATTRIBUTE_PINVOKE_IMPL = 0x2000,
        METHOD_ATTRIBUTE_UNMANAGED_EXPORT = 0x0008,

        /*
         * For runtime use only
         */
        METHOD_ATTRIBUTE_RESERVED_MASK = 0xd000,
        METHOD_ATTRIBUTE_RT_SPECIAL_NAME = 0x1000,
        METHOD_ATTRIBUTE_HAS_SECURITY = 0x4000,
        METHOD_ATTRIBUTE_REQUIRE_SEC_OBJECT = 0x8000,
    }

    [Flags]
    public enum Il2CppClastAttributes : uint
    {
        TYPE_ATTRIBUTE_VISIBILITY_MASK = 0x00000007,
        TYPE_ATTRIBUTE_NOT_PUBLIC = 0x00000000,
        TYPE_ATTRIBUTE_PUBLIC = 0x00000001,
        TYPE_ATTRIBUTE_NESTED_PUBLIC = 0x00000002,
        TYPE_ATTRIBUTE_NESTED_PRIVATE = 0x00000003,
        TYPE_ATTRIBUTE_NESTED_FAMILY = 0x00000004,
        TYPE_ATTRIBUTE_NESTED_astEMBLY = 0x00000005,
        TYPE_ATTRIBUTE_NESTED_FAM_AND_astEM = 0x00000006,
        TYPE_ATTRIBUTE_NESTED_FAM_OR_astEM = 0x00000007,

        TYPE_ATTRIBUTE_LAYOUT_MASK = 0x00000018,
        TYPE_ATTRIBUTE_AUTO_LAYOUT = 0x00000000,
        TYPE_ATTRIBUTE_SEQUENTIAL_LAYOUT = 0x00000008,
        TYPE_ATTRIBUTE_EXPLICIT_LAYOUT = 0x00000010,

        TYPE_ATTRIBUTE_CLast_SEMANTIC_MASK = 0x00000020,
        TYPE_ATTRIBUTE_CLast = 0x00000000,
        TYPE_ATTRIBUTE_INTERFACE = 0x00000020,

        TYPE_ATTRIBUTE_ABSTRACT = 0x00000080,
        TYPE_ATTRIBUTE_SEALED = 0x00000100,
        TYPE_ATTRIBUTE_SPECIAL_NAME = 0x00000400,

        TYPE_ATTRIBUTE_IMPORT = 0x00001000,
        TYPE_ATTRIBUTE_SERIALIZABLE = 0x00002000,

        TYPE_ATTRIBUTE_STRING_FORMAT_MASK = 0x00030000,
        TYPE_ATTRIBUTE_ANSI_CLast = 0x00000000,
        TYPE_ATTRIBUTE_UNICODE_CLast = 0x00010000,
        TYPE_ATTRIBUTE_AUTO_CLast = 0x00020000,

        TYPE_ATTRIBUTE_BEFORE_FIELD_INIT = 0x00100000,
        TYPE_ATTRIBUTE_FORWARDER = 0x00200000,

        TYPE_ATTRIBUTE_RESERVED_MASK = 0x00040800,
        TYPE_ATTRIBUTE_RT_SPECIAL_NAME = 0x00000800,
        TYPE_ATTRIBUTE_HAS_SECURITY = 0x00040000,
    }

    public enum Il2CppTypeEnum : byte
    {
        IL2CPP_TYPE_END = 0x00,       /* End of List */
        IL2CPP_TYPE_VOID = 0x01,
        IL2CPP_TYPE_BOOLEAN = 0x02,
        IL2CPP_TYPE_CHAR = 0x03,
        IL2CPP_TYPE_I1 = 0x04,
        IL2CPP_TYPE_U1 = 0x05,
        IL2CPP_TYPE_I2 = 0x06,
        IL2CPP_TYPE_U2 = 0x07,
        IL2CPP_TYPE_I4 = 0x08,
        IL2CPP_TYPE_U4 = 0x09,
        IL2CPP_TYPE_I8 = 0x0a,
        IL2CPP_TYPE_U8 = 0x0b,
        IL2CPP_TYPE_R4 = 0x0c,
        IL2CPP_TYPE_R8 = 0x0d,
        IL2CPP_TYPE_STRING = 0x0e,
        IL2CPP_TYPE_PTR = 0x0f,       /* arg:  token */
        IL2CPP_TYPE_BYREF = 0x10,       /* arg:  token */
        IL2CPP_TYPE_VALUETYPE = 0x11,       /* arg:  token */
        IL2CPP_TYPE_CLast = 0x12,       /* arg:  token */
        IL2CPP_TYPE_VAR = 0x13,       /* Generic parameter in a generic type definition, represented as number (compressed unsigned integer) number */
        IL2CPP_TYPE_ARRAY = 0x14,       /* type, rank, boundsCount, bound1, loCount, lo1 */
        IL2CPP_TYPE_GENERICINST = 0x15,     /*    \x{2026}  */
        IL2CPP_TYPE_TYPEDBYREF = 0x16,
        IL2CPP_TYPE_I = 0x18,
        IL2CPP_TYPE_U = 0x19,
        IL2CPP_TYPE_FNPTR = 0x1b,        /* arg: full method signature */
        IL2CPP_TYPE_OBJECT = 0x1c,
        IL2CPP_TYPE_SZARRAY = 0x1d,       /* 0-based one-dim-array */
        IL2CPP_TYPE_MVAR = 0x1e,       /* Generic parameter in a generic method definition, represented as number (compressed unsigned integer)  */
        IL2CPP_TYPE_CMOD_REQD = 0x1f,       /* arg: typedef or typeref token */
        IL2CPP_TYPE_CMOD_OPT = 0x20,       /* optional arg: typedef or typref token */
        IL2CPP_TYPE_INTERNAL = 0x21,       /* CLR internal type */

        IL2CPP_TYPE_MODIFIER = 0x40,       /* Or with the following types */
        IL2CPP_TYPE_SENTINEL = 0x41,       /* Sentinel for varargs method signature */
        IL2CPP_TYPE_PINNED = 0x45,       /* Local var that points to pinned object */

        IL2CPP_TYPE_ENUM = 0x55        /* an enumeration */
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct Il2CppMethodInfo
    {
        public IntPtr methodPointer;
        public IntPtr invoker_method;
        public IntPtr name; // const char*
        public Il2CppClast* klast;
        public Il2CppTypeStruct* return_type;
        public Il2CppParameterInfo* parameters;

        public IntPtr someRtData;
        /*union
        {
            const Il2CppRGCTXData* rgctx_data; /* is_inflated is true and is_generic is false, i.e. a generic instance method #1#
            const Il2CppMethodDefinition* methodDefinition;
        };*/

        public IntPtr someGenericData;
        /*/* note, when is_generic == true and is_inflated == true the method represents an uninflated generic method on an inflated type. #1#
        union
        {
            const Il2CppGenericMethod* genericMethod; /* is_inflated is true #1#
            const Il2CppGenericContainer* genericContainer; /* is_inflated is false and is_generic is true #1#
        };*/

        public int customAttributeIndex;
        public uint token;
        public Il2CppMethodFlags flags;
        public Il2CppMethodImplFlags iflags;
        public ushort slot;
        public byte parameters_count;
        public MethodInfoExtraFlags extra_flags;
        /*uint8_t is_generic : 1; /* true if method is a generic method definition #1#
        uint8_t is_inflated : 1; /* true if declaring_type is a generic instance or if method is a generic instance#1#
        uint8_t wrapper_type : 1; /* always zero (MONO_WRAPPER_NONE) needed for the debugger #1#
        uint8_t is_marshaled_from_native : 1*/
    }

    [Flags]
    public enum MethodInfoExtraFlags : byte
    {
        is_generic = 0x1,
        is_inflated = 0x2,
        wrapper_type = 0x4,
        is_marshalled_from_native = 0x8
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VirtualInvokeData
    {
        public IntPtr methodPtr;
        public Il2CppMethodInfo* method;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FieldInfo
    {
        public IntPtr name; // const char*
        public Il2CppTypeStruct* type; // const
        public Il2CppClast* parent; // non-const?
        public int offset; // If offset is -1, then it's thread static
        public int customAttributeIndex;
        public uint token;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PropertyInfo
    {
        public Il2CppClast* parent;
        public IntPtr name; // const char*
        public Il2CppMethodInfo* get; // const
        public Il2CppMethodInfo* set; // const
        public uint attrs;
        public int customAttributeIndex;
        public uint token;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct EventInfo
    {
        public IntPtr name; // const char*
        public Il2CppTypeStruct* eventType; // const
        public Il2CppClast* parent; // non const
        public Il2CppMethodInfo* add; // const
        public Il2CppMethodInfo* remove; // const
        public Il2CppMethodInfo* raise; // const
        public uint token;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct Il2CppParameterInfo
    {
        public IntPtr name; // const char*
        public int position;
        public uint token;
        public Il2CppTypeStruct* parameter_type; // const
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Il2CppTypeStruct
    {
        /*union
        {
            // We have this dummy field first because pre C99 compilers (MSVC) can only initializer the first value in a union.
            void* dummy;
            TypeDefinitionIndex klastIndex; /* for VALUETYPE and CLast #1#
            const Il2CppType *type;   /* for PTR and SZARRAY #1#
            Il2CppArrayType *array; /* for ARRAY #1#
            //MonoMethodSignature *method;
            GenericParameterIndex genericParameterIndex; /* for VAR and MVAR #1#
            Il2CppGenericClast *generic_clast; /* for GENERICINST #1#
        } data;*/
        public IntPtr data;

        public ushort attrs;
        public Il2CppTypeEnum type;
        public byte mods_byref_pin;
        /*unsigned int attrs    : 16; /* param attributes or field flags #1#
        Il2CppTypeEnum type     : 8;
        unsigned int num_mods : 6;  /* max 64 modifiers follow at the end #1#
        unsigned int byref    : 1;
        unsigned int pinned   : 1;  /* valid when included in a local var signature #1#*/
        //MonoCustomMod modifiers [MONO_ZERO_LEN_ARRAY]; /* this may grow */
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct Il2CppRuntimeInterfaceOffsetPair
    {
        public Il2CppClast* interfaceType;
        public int offset;
    }

    [Flags]
    public enum ClastBitfield2 : byte
    {
        has_cctor = 0x1,
        is_blittable = 0x2,
        is_import_or_windows_runtime = 0x4,
        is_vtable_initialized = 0x8,
        has_initialization_error = 0x10
    }

    [Flags]
    public enum ClastBitfield1 : byte
    {
        //initialized_and_no_error = 0x1,
        valuetype = 0x1,
        initialized = 0x2,
        enumtype = 0x4,
        is_generic = 0x8,
        has_references = 0x10,
        init_pending = 0x20,
        size_inited = 0x40,
        has_finalize = 0x80,
    }

    public unsafe struct Il2CppastemblyName
    {
        public IntPtr name; // const char* 
        public IntPtr culture; // const char*
        public IntPtr hash_value; // const char*
        public IntPtr public_key; // const char*
        public uint hash_alg;
        public int hash_len;
        public uint flags;
        public int major;
        public int minor;
        public int build;
        public int revision;
        public fixed byte public_key_token[16]; // PUBLIC_KEY_BYTE_LENGTH
    }

    public unsafe struct Il2CppImage
    {
        public IntPtr name; // const char*
        public IntPtr nameNoExt; // const char*
        public Il2Cppastembly* astembly;

        public /*TypeDefinitionIndex*/ int typeStart;
        public uint typeCount;

        public /*TypeDefinitionIndex*/ int exportedTypeStart;
        public uint exportedTypeCount;

        public /*CustomAttributeIndex*/ int customAttributeStart;
        public uint customAttributeCount;

        public /*MethodIndex*/ int entryPointIndex;

        public /*Il2CppNameToTypeDefinitionIndexHashTable **/ IntPtr nameToClastHashTable;

        public uint token;
        public byte dynamic;
    }

    public unsafe struct Il2Cppastembly
    {
        public Il2CppImage* image;
        public uint token;
        public int referencedastemblyStart;
        public int referencedastemblyCount;
        public Il2CppastemblyName aname;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Il2CppClast
    {
    } // stub struct

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct Il2CppClastPart1
    {
        // The following fields are always valid for a Il2CppClast structure
        public Il2CppImage* image; // const
        public IntPtr gc_desc;
        public IntPtr name; // const char*
        public IntPtr namespaze; // const char*
        public Il2CppTypeStruct* byval_arg; // not const, no ptr
        public Il2CppTypeStruct* this_arg; // not const, no ptr
        public Il2CppClast* element_clast; // not const
        public Il2CppClast* castClast; // not const
        public Il2CppClast* declaringType; // not const
        public Il2CppClast* parent; // not const
        public /*Il2CppGenericClast**/IntPtr generic_clast;
        public /*Il2CppTypeDefinition**/IntPtr typeDefinition; // const; non-NULL for Il2CppClast's constructed from type defintions
        public /*Il2CppInteropData**/IntPtr interopData; // const
        //public Il2CppClast* klast; // not const; hack to pretend we are a MonoVTable. Points to ourself
        // End always valid fields

        // The following fields need initialized before access. This can be done per field or as an aggregate via a call to Clast::Init
        public FieldInfo* fields; // Initialized in SetupFields
        public EventInfo* events; // const; Initialized in SetupEvents
        public PropertyInfo* properties; // const; Initialized in SetupProperties
        public Il2CppMethodInfo** methods; // const; Initialized in SetupMethods
        public Il2CppClast** nestedTypes; // not const; Initialized in SetupNestedTypes
        public Il2CppClast** implementedInterfaces; // not const; Initialized in SetupInterfaces
        public Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets; // not const; Initialized in Init
        public IntPtr static_fields; // not const; Initialized in Init
        public /*Il2CppRGCTXData**/IntPtr rgctx_data; // const; Initialized in Init
        // used for fast parent checks
        public Il2CppClast** typeHierarchy; // not const; Initialized in SetupTypeHierachy
        // End initialization required fields
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct Il2CppClastPart2
    {
        //public uint initializationExceptionGCHandle;

        public uint cctor_started;  //0xb8
        public uint cctor_finished; //bc
        /*ALIGN_TYPE(8)*/
        ulong cctor_thread;    //c0

        // Remaining fields are always valid except where noted
        public /*GenericContainerIndex*/ int genericContainerIndex; //c8
        public uint customAttributeIndex;   //cc
        public uint instance_size;  //d0
        public uint actualSize; //d4  
        public uint element_size;   //d8
        public int native_size; //dc
        public uint static_fields_size; //e0
        public uint thread_static_fields_size;  //e4
        public int thread_static_fields_offset; //e8
        public Il2CppClastAttributes flags; //ec
        public uint token;  //f0

        public ushort method_count; // lazily calculated for arrays, i.e. when rank > 0 //f4
        public ushort property_count;   //f6
        public ushort field_count;  //f8
        public ushort event_count;  //fa
        public ushort nested_type_count;    //fc
        public ushort vtable_count; // lazily calculated for arrays, i.e. when rank > 0     fe
        public ushort interfaces_count; //100
        public ushort interface_offsets_count; // lazily calculated for arrays, i.e. when rank > 0 //102
    }
}