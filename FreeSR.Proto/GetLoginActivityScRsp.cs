namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetLoginActivityScRsp
	{
		[ProtoMember(4)] public List<LoginActivityData> LoginActivityList;
		[ProtoMember(14)] public int Retcode;
	}

}
