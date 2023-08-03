namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetLoginActivityScRsp
	{
		[ProtoMember(2)] public List<LoginActivityData> LoginActivityList;
		[ProtoMember(12)] public int Retcode;
	}
	
}
