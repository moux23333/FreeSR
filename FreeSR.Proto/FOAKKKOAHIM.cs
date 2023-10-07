namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class FOAKKKOAHIM
	{
		[ProtoMember(12)] public int Uid;
		[ProtoMember(7)] public int Retcode;
		[ProtoMember(2)] public string Eoljaamdenk;
	}

}
