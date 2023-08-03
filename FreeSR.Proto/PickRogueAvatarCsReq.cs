namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class PickRogueAvatarCsReq
	{
		[ProtoMember(2)] public List<int> PCNOGANHLGL;
		[ProtoMember(8)] public int PropEntityId;
		[ProtoMember(4)] public List<int> BaseAvatarIdList;
	}
	
}
