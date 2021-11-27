using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

public class DrawDotHub: Hub {
   public async Task UpdateCanvas(int x, int y) {
      await Clients.Caller.SendAsync("updateDot",x, y);
   }

   public async Task ClearCanvas() {
      await Clients.Caller.SendAsync("clearCanvas");
   }
}
