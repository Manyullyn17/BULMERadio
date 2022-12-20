
#include "mbed.h"
#include "Serial_HL.h"

SerialBLK pc(USBTX, USBRX);
SvProtocol ua0(&pc);

void SetPriorities();
void CommandHandler();

int main(void)
{
	pc.format(8,SerialBLK::None,1); pc.baud(256000); // pc.Init();
	ua0.SvMessage("Das ist ein Test"); 

	SetPriorities();
	ua0.SvMessage("MPU OK");
	
	Timer stw; stw.start();
	while(1) {
		CommandHandler();
		if( stw.read_ms()>10 ) { 
			stw.reset();
			if( ua0.acqON ) {
				/*ua0.WriteSvI16(1, gyY);
				ua0.WriteSvI16(2, accX);
				ua0.WriteSvI16(3, cycTime);*/
				pc.Flush();
			}
		}
  }
  return 1;
}

void CommandHandler()
{
	uint8_t cmd;
	if( !pc.IsDataAvail() )
		return;
	cmd = ua0.GetCommand();
	if( cmd==2 ) {
		
		ua0.SvMessage("Reset");
	}
	if( cmd==3 ) {
		ua0.SvMessage("CalcOffset");
		ua0.SvMessage("CalcOffset done");
	}
}

void SetPriorities()
{
	HAL_NVIC_DisableIRQ(SysTick_IRQn);
	HAL_NVIC_DisableIRQ(EXTI15_10_IRQn);
	
	HAL_NVIC_SetPriority(EXTI15_10_IRQn, 2, 0);
	HAL_NVIC_SetPriority(SysTick_IRQn, 5, 0);
	
	HAL_NVIC_EnableIRQ(SysTick_IRQn);
	HAL_NVIC_EnableIRQ(EXTI15_10_IRQn);

	HAL_NVIC_SetPriority(USART1_IRQn, 4, 0);
	HAL_NVIC_SetPriority(USART2_IRQn, 4, 0);
}