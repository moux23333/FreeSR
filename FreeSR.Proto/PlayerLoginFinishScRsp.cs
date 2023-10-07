namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class PlayerLoginFinishScRsp
	{
		[ProtoMember(3)] public int Retcode;
	}
	
}
