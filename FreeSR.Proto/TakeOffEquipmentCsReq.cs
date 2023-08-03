namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeOffEquipmentCsReq
	{
		[ProtoMember(7)] public int BaseAvatarId;
	}
	
}
