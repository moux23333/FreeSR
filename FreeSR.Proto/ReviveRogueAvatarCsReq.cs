namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ReviveRogueAvatarCsReq
	{
		[ProtoMember(14)] public int ShopId;
		[ProtoMember(5)] public int BaseAvatarId;
		[ProtoMember(11)] public List<int> BaseAvatarIdList;
		[ProtoMember(4)] public List<int> PCNOGANHLGL;
	}
	
}
