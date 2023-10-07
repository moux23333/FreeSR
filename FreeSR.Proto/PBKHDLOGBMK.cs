namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class PBKHDLOGBMK
	{
		[ProtoMember(5)] public ItemList Reward;
		[ProtoMember(10)] public int Retcode;
		[ProtoMember(1)] public int Dklobaachnn;
	}

}
