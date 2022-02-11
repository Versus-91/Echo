import { EchoTemplatePage } from './app.po';

describe('Echo App', function() {
  let page: EchoTemplatePage;

  beforeEach(() => {
    page = new EchoTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
