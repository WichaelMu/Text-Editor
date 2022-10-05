using System.Diagnostics;

namespace Engine
{
	public interface ITick<F> where F : Form
	{
		public bool bCanTick { get; }

		public bool bIsTicking { get; set; }

		public void Tick(float DeltaTime);

		public void OnStart()
		{
			ThisAsForm().Load += BeginTick;
		}

		public Form ThisAsForm()
		{
			return (Form)this;
		}

		async void BeginTick(object Sender, EventArgs E)
		{
			Stopwatch sw = new Stopwatch();
			sw.Start();
			long Prev = sw.ElapsedMilliseconds;

			while (true)
			{
				long DeltaTime = sw.ElapsedMilliseconds - Prev;
				Prev = sw.ElapsedMilliseconds;

				await Task.Delay(5);

				if (bCanTick)
					Tick(DeltaTime * .001f);
			}
		}
	}
}
