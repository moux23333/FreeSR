namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetNpcMessageGroupScRsp
	{
		[ProtoMember(7)] public List<MessageGroup> MessageGroupList;
		[ProtoMember(4)] public int Retcode;
	}
	
}
