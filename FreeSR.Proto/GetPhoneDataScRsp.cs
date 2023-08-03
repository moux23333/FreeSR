namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetPhoneDataScRsp
	{
		[ProtoMember(2)] public List<int> MICAEKDOFLH;
		[ProtoMember(3)] public int DDAKBIDPPIC;
		[ProtoMember(11)] public int Retcode;
	}
	
}
