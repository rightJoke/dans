class VamtamTabsHandler extends elementorModules.frontend.handlers.Base{getDefaultSettings(){return{selectors:{tabTitle:".elementor-tab-title",tabContent:".elementor-tab-content"},classes:{active:"elementor-active"},showTabFn:"show",hideTabFn:"hide",toggleSelf:!0,hidePrevious:!0,autoExpand:!0}}getDefaultElements(){const selectors=this.getSettings("selectors");return{$tabTitles:this.findElement(selectors.tabTitle),$tabContents:this.findElement(selectors.tabContent)}}activateDefaultTab(){const settings=this.getSettings();if(!settings.autoExpand||"editor"===settings.autoExpand&&!this.isEdit)return;const defaultActiveTab=this.getEditSettings("activeItemIndex")||1,originalToggleMethods={showTabFn:settings.showTabFn,hideTabFn:settings.hideTabFn};this.setSettings({showTabFn:"show",hideTabFn:"hide"}),this.changeActiveTab(defaultActiveTab),this.setSettings(originalToggleMethods)}deactivateActiveTab(tabIndex){const settings=this.getSettings(),activeClass=settings.classes.active,activeFilter=tabIndex?'[data-tab="'+tabIndex+'"]':"."+activeClass,$activeTitle=this.elements.$tabTitles.filter(activeFilter),$activeContent=this.elements.$tabContents.filter(activeFilter);$activeTitle.add($activeContent).removeClass(activeClass),$activeContent[settings.hideTabFn]()}activateTab(tabIndex){const settings=this.getSettings(),activeClass=settings.classes.active,$requestedTitle=this.elements.$tabTitles.filter('[data-tab="'+tabIndex+'"]'),$requestedContent=this.elements.$tabContents.filter('[data-tab="'+tabIndex+'"]'),animationDuration="show"===settings.showTabFn?0:400;$requestedTitle.add($requestedContent).addClass(activeClass),$requestedContent[settings.showTabFn](animationDuration,()=>elementorFrontend.elements.$window.trigger("resize"))}isActiveTab(tabIndex){return this.elements.$tabTitles.filter('[data-tab="'+tabIndex+'"]').hasClass(this.getSettings("classes.active"))}bindEvents(){this.elements.$tabTitles.on({keydown:event=>{"Enter"===event.key&&(event.preventDefault(),this.changeActiveTab(event.currentTarget.getAttribute("data-tab")))},click:event=>{event.preventDefault(),this.changeActiveTab(event.currentTarget.getAttribute("data-tab"))}})}onInit(...args){super.onInit(...args),this.activateDefaultTab()}onEditSettingsChange(propertyName){"activeItemIndex"===propertyName&&this.activateDefaultTab()}changeActiveTab(tabIndex){const isActiveTab=this.isActiveTab(tabIndex),settings=this.getSettings();!settings.toggleSelf&&isActiveTab||!settings.hidePrevious||this.deactivateActiveTab(),!settings.hidePrevious&&isActiveTab&&this.deactivateActiveTab(tabIndex),isActiveTab||(this.activateTab(tabIndex),this.checkApplySwiperSliderFix(tabIndex),this.triggerInnerAnims(tabIndex))}checkApplySwiperSliderFix(tabIndex){if(!tabIndex)return;const $swiperSlider=this.elements.$tabContents.eq(parseInt(tabIndex)-1).find(".elementor-swiper");$swiperSlider.length&&window.dispatchEvent(new Event("resize"))}triggerInnerAnims(tabIndex){const activeTabIndex=tabIndex.toString(),$activeContent=this.elements.$tabContents.filter('[data-tab="'+activeTabIndex+'"]'),$animsInTab=$activeContent.find('[data-settings*="animation"]');if(this.tabsAnimated){if(this.tabsAnimated.includes(activeTabIndex))return}else this.tabsAnimated=[];function getAnimation(settings){return elementorFrontend.getCurrentDeviceSetting(settings,"animation")||elementorFrontend.getCurrentDeviceSetting(settings,"_animation")}function getAnimationDelay(settings){return elementorFrontend.getCurrentDeviceSetting(settings,"animation_delay")||elementorFrontend.getCurrentDeviceSetting(settings,"_animation_delay")||0}const _self=this;$animsInTab.each((function(i,el){const $el=jQuery(el),settings=$el.data("settings"),anim=settings&&getAnimation(settings),animDelay=settings&&getAnimationDelay(settings);anim&&(_self.tabsAnimated.push(activeTabIndex),$el.addClass("elementor-invisible").removeClass("animated").removeClass(anim),setTimeout((function(){$el.removeClass("elementor-invisible").addClass("animated "+anim)}),animDelay))}))}}jQuery(window).on("elementor/frontend/init",()=>{if(elementorFrontend.elementsHandler&&elementorFrontend.elementsHandler.attachHandler)elementorFrontend.elementsHandler.attachHandler("tabs",VamtamTabsHandler);else{const addHandler=$element=>{elementorFrontend.elementsHandler.addHandler(VamtamTabsHandler,{$element:$element})};elementorFrontend.hooks.addAction("frontend/element_ready/tabs.default",addHandler,-9999)}});