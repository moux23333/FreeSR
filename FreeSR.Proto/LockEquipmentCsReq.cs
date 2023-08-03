namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class LockEquipmentCsReq
	{
		[ProtoMember(6)] public int EquipmentUniqueId;
		[ProtoMember(7)] public bool IsLock;
	}
	
}
