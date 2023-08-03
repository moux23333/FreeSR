namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class DressAvatarCsReq
	{
		[ProtoMember(14)] public int BaseAvatarId;
		[ProtoMember(3)] public int EquipmentUniqueId;
	}
	
}
