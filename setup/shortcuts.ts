import type { NavOperations, ShortcutOptions } from '@slidev/types'
import { defineShortcutsSetup } from '@slidev/types'

export default defineShortcutsSetup((nav: NavOperations, base: ShortcutOptions[]) => {
    return [
        ...base,
        {
            key: 'Ctrl+B',
            fn: () => nav.showGotoDialog(),
        }
    ]
});