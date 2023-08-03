namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetNpcStatusScRsp
	{
		[ProtoMember(13)] public List<NpcStatus> MessageStatusList;
		[ProtoMember(15)] public int Retcode;
	}
	
}
