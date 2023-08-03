namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class PlayerLoginFinishScRsp
	{
		[ProtoMember(5)] public int Retcode;
	}
	
}
