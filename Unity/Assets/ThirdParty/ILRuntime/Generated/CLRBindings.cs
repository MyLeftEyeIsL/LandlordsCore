using System;
using System.Collections.Generic;
using System.Reflection;

namespace ILRuntime.Runtime.Generated
{
    class CLRBindings
    {


        /// <summary>
        /// Initialize the CLR binding, please invoke this AFTER CLR Redirection registration
        /// </summary>
        public static void Initialize(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            System_NotImplementedException_Binding.Register(app);
            System_String_Binding.Register(app);
            System_Exception_Binding.Register(app);
            System_Collections_IDictionary_Binding.Register(app);
            LitJson_JsonMapper_Binding.Register(app);
            ETModel_Log_Binding.Register(app);
            ETModel_Entity_Binding.Register(app);
            ETModel_Game_Binding.Register(app);
            ETModel_ClientComponent_Binding.Register(app);
            ETModel_Component_Binding.Register(app);
            ETModel_User_Binding.Register(app);
            UnityEngine_LayerMask_Binding.Register(app);
            UnityEngine_Input_Binding.Register(app);
            UnityEngine_Camera_Binding.Register(app);
            UnityEngine_Physics_Binding.Register(app);
            UnityEngine_RaycastHit_Binding.Register(app);
            ETModel_SessionComponent_Binding.Register(app);
            ETModel_Frame_ClickMap_Binding.Register(app);
            UnityEngine_Vector3_Binding.Register(app);
            ETModel_Session_Binding.Register(app);
            System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Binding.Register(app);
            System_Threading_Tasks_Task_1_ILTypeInstance_Binding.Register(app);
            System_Runtime_CompilerServices_TaskAwaiter_1_ILTypeInstance_Binding.Register(app);
            ETModel_ResourcesComponent_Binding.Register(app);
            ETModel_Actor_CreateUnits_Binding.Register(app);
            System_Collections_Generic_List_1_UnitInfo_Binding.Register(app);
            System_Collections_Generic_List_1_UnitInfo_Binding_Enumerator_Binding.Register(app);
            ETModel_UnitInfo_Binding.Register(app);
            ETModel_UnitComponent_Binding.Register(app);
            ETModel_UnitFactory_Binding.Register(app);
            ETModel_Unit_Binding.Register(app);
            VInt3_Binding.Register(app);
            ETModel_PlayerComponent_Binding.Register(app);
            ETModel_Player_Binding.Register(app);
            ETModel_ComponentWithId_Binding.Register(app);
            ETModel_CameraComponent_Binding.Register(app);
            System_IDisposable_Binding.Register(app);
            ETModel_Actor_Test_Binding.Register(app);
            ETModel_MoveComponent_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int64_Int32_Binding.Register(app);
            UnityEngine_UI_Text_Binding.Register(app);
            UnityEngine_Component_Binding.Register(app);
            UnityEngine_GameObject_Binding.Register(app);
            ETModel_GameObjectHelper_Binding.Register(app);
            UnityEngine_Object_Binding.Register(app);
            System_Type_Binding.Register(app);
            System_Enum_Binding.Register(app);
            UnityEngine_UI_Image_Binding.Register(app);
            System_Int64_Binding.Register(app);
            ETModel_Card_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_GameObject_Binding.Register(app);
            System_Int32_Binding.Register(app);
            System_Collections_Generic_List_1_Card_Binding.Register(app);
            UnityEngine_RectTransform_Binding.Register(app);
            UnityEngine_Vector2_Binding.Register(app);
            UnityEngine_Transform_Binding.Register(app);
            ETModel_HandCardSprite_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int64_Int64_Binding.Register(app);
            System_Collections_Generic_List_1_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int64_Identity_Binding.Register(app);
            System_Collections_Generic_KeyValuePair_2_Int64_Card_Array_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int64_Boolean_Binding.Register(app);
            ReferenceCollector_Binding.Register(app);
            UnityEngine_UI_Button_Binding.Register(app);
            ETModel_ActionHelper_Binding.Register(app);
            ETModel_GlobalConfigComponent_Binding.Register(app);
            ETModel_GlobalProto_Binding.Register(app);
            ETModel_NetworkHelper_Binding.Register(app);
            ETModel_NetworkComponent_Binding.Register(app);
            ETModel_SessionCallbackComponent_Binding.Register(app);
            UnityEngine_UI_InputField_Binding.Register(app);
            ETModel_ComponentFactory_Binding.Register(app);
            UnityEngine_Color_Binding.Register(app);
            UnityEngine_UI_Graphic_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Type_ILTypeInstance_Binding.Register(app);
            ETModel_Hotfix_Binding.Register(app);
            System_Reflection_MemberInfo_Binding.Register(app);
            System_Activator_Binding.Register(app);
            UnityEngine_TextAsset_Binding.Register(app);
            ETModel_IdGenerater_Binding.Register(app);
            System_Collections_Generic_HashSet_1_ILTypeInstance_Binding.Register(app);
            System_Object_Binding.Register(app);
            System_Linq_Enumerable_Binding.Register(app);
            System_Collections_Generic_HashSet_1_ILTypeInstance_Binding_Enumerator_Binding.Register(app);
            System_Collections_Generic_List_1_Object_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_List_1_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int64_ILTypeInstance_Binding.Register(app);
            ETModel_UnOrderMultiMap_2_Type_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Queue_1_Int64_Binding.Register(app);
            System_Collections_Generic_List_1_ILTypeInstance_Binding_Enumerator_Binding.Register(app);
            ETModel_EventAttribute_Binding.Register(app);
            ETModel_EventProxy_Binding.Register(app);
            ETModel_EventSystem_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Type_Queue_1_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_Queue_1_ILTypeInstance_Binding.Register(app);
            ETModel_Packet_Binding.Register(app);
            ETModel_ProtobufHelper_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int32_Action_1_ILTypeInstance_Binding.Register(app);
            ETModel_MessageInfo_Binding.Register(app);
            System_Threading_Tasks_TaskCompletionSource_1_ILTypeInstance_Binding.Register(app);
            System_Threading_CancellationToken_Binding.Register(app);
            ETModel_RpcException_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_UInt16_List_1_ILTypeInstance_Binding.Register(app);
            ETModel_OpcodeTypeComponent_Binding.Register(app);
            ETModel_MessageProxy_Binding.Register(app);
            ETModel_MessageDispatherComponent_Binding.Register(app);
            ETModel_MessageAttribute_Binding.Register(app);
            ETModel_DoubleMap_2_UInt16_Type_Binding.Register(app);
            ProtoBuf_PType_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_ILTypeInstance_Binding.Register(app);
            ETModel_UIFactoryAttribute_Binding.Register(app);
            ETModel_CanvasConfig_Binding.Register(app);
            System_Collections_Generic_List_1_String_Binding.Register(app);
            ETModel_Scene_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_ILTypeInstance_Binding_ValueCollection_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_String_ILTypeInstance_Binding_ValueCollection_Binding_Enumerator_Binding.Register(app);
            ETModel_Actor_TestRequest_Binding.Register(app);
            System_Threading_Tasks_Task_1_IResponse_Binding.Register(app);
            System_Runtime_CompilerServices_TaskAwaiter_1_IResponse_Binding.Register(app);
            ETModel_Actor_TransferRequest_Binding.Register(app);
            ETModel_C2G_EnterMap_Binding.Register(app);

            ILRuntime.CLR.TypeSystem.CLRType __clrType = null;
        }

        /// <summary>
        /// Release the CLR binding, please invoke this BEFORE ILRuntime Appdomain destroy
        /// </summary>
        public static void Shutdown(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
        }
    }
}
