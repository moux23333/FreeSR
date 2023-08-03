namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class LockEquipmentScRsp
	{
		[ProtoMember(2)] public int EquipmentUniqueId;
		[ProtoMember(12)] public int Retcode;
	}
	
}
