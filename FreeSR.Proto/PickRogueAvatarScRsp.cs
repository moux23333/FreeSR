namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class PickRogueAvatarScRsp
	{
		[ProtoMember(10)] public List<int> BaseAvatarIdList;
		[ProtoMember(3)] public int Retcode;
		[ProtoMember(12)] public List<int> PCNOGANHLGL;
	}
	
}
